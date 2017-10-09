using System;
using System.Collections.Generic;
using System.Linq;
using PLCSimulator;
using System.Xml.Serialization;
using System.IO;
using System.Threading;
using DataConcentrator.Model;
using DataConcentrator.Model.DatabaseManager;

namespace DataConcentrator
{
    public delegate void AlarmHandler(string message);
    public delegate void ValueChangedHandler(string tagId, double value);
    
    public class DataConcentratorManager
    {
        PLCSimulatorManager plcSimulatorManager;

        private Dictionary<string, Thread> threads;
        public Dictionary<string, Tag> Tags;
        public Dictionary<string, double> CurrentValues;
        public Dictionary<string, bool> Alarms;

        public event AlarmHandler AlarmHandler;
        public event ValueChangedHandler ValueChangedHandler;

        public AppDbContext DbContext { get; private set; } = new AppDbContext();

        public DataConcentratorManager()
        {
            plcSimulatorManager = new PLCSimulatorManager();
            plcSimulatorManager.StartPLCSimulator();

            Tags = new Dictionary<string, Tag>();
            Alarms = new Dictionary<string, bool>();
            CurrentValues = new Dictionary<string, double>();
            threads = new Dictionary<string, Thread>();

            LoadData();
        }

        public bool AddTag(Tag tag)
        {
            if (!Tags.ContainsKey(tag.Id))
            {
                if (plcSimulatorManager.AddressValues.ContainsKey(tag.Address))
                {
                    if (tag is OutputTag)
                    {
                        var t = (OutputTag)tag;
                        plcSimulatorManager.AddressValues[t.Address] = t.InitialValue;
                    }
                    else if (tag is InputTag)
                    {
                        var t = (InputTag)tag;
                        Thread thread = new Thread(new ParameterizedThreadStart(Scan));
                        threads[t.Id] = thread;
                        thread.Start(t);
                    }
                    Tags[tag.Id] = tag;
                    CurrentValues[tag.Id] = plcSimulatorManager.AddressValues[tag.Address];
                    return true;
                }
            }
            return false;
        }

        public bool RemoveTag(string tagId)
        {
            if (Tags.ContainsKey(tagId))
            {
                if (Tags[tagId] is InputTag)
                {
                    Thread t = threads[tagId];
                    t.Abort();
                    threads.Remove(tagId);
                    if (Tags[tagId].GetType() == typeof(AnalogInput))
                    {
                        var tag = (AnalogInput)Tags[tagId];
                        if (tag.Alarms != null)
                        {
                            foreach (var alarm in tag.Alarms)
                            {
                                Alarms.Remove(alarm.Id);
                            }
                        }
                    }
                }
                Tags.Remove(tagId);
                CurrentValues.Remove(tagId);
                return true;
            }
            return false;
        }

        public bool AddAlarm(string alarmId)
        {
            if (!Alarms.ContainsKey(alarmId))
            {
                Alarms[alarmId] = false;
                return true;
            }
            return false;
        }

        public void AddAlarmToTag(string tagId, Alarm alarm)
        {
            ((AnalogInput)Tags[tagId]).Alarms.Add(alarm);
        }

        public bool RemoveAlarm(string tagId, string alarmId)
        {
            if (Alarms.ContainsKey(alarmId))
            {
                Alarm alarmToRemove = ((AnalogInput)Tags[tagId]).Alarms.FirstOrDefault(a => a.Id == alarmId);
                ((AnalogInput)Tags[tagId]).Alarms.Remove(alarmToRemove);
                Alarms.Remove(alarmId);
                return true;
            }
            return false;
        }

        public bool WriteToTag(string tagId, double newValue)
        {
            if (Tags.ContainsKey(tagId))
            {
                CurrentValues[tagId] = newValue;
                plcSimulatorManager.AddressValues[Tags[tagId].Address] = newValue;
                return true;
            }
            return false;
        }

        public void SaveData()
        {
            List<Tag> tagDtos = Tags.Values.ToList();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Tag>));

            using (TextWriter textWriter = new StreamWriter("Configure.xml"))
            {
                serializer.Serialize(textWriter, tagDtos);
            }
        }

        public void LoadData()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Tag>));

            if (!File.Exists("Configure.xml"))
            {
                return;
            }

            using (TextReader textReader = new StreamReader("Configure.xml"))
            {
                if (textReader.Peek() != -1)
                {
                    List<Tag> tagDtos = (List<Tag>)serializer.Deserialize(textReader);
                    foreach (Tag tag in tagDtos)
                    {
                        Tags[tag.Id] = tag;
                        CurrentValues[tag.Id] = plcSimulatorManager.AddressValues[tag.Address];
                        if (tag is InputTag)
                        {
                            var t = (InputTag)tag;
                            Thread thread = new Thread(new ParameterizedThreadStart(Scan));
                            threads[t.Id] = thread;
                            thread.Start(t);

                            if (tag.GetType() == typeof(AnalogInput))
                            {
                                var analogTag = (AnalogInput)tag;
                                if (analogTag.Alarms != null)
                                {
                                    foreach (var alarm in analogTag.Alarms)
                                    {
                                        Alarms[alarm.Id] = false;
                                    }
                                }
                            }

                        }
                    }
                }
            }
        }

        private void Scan(object obj)
        {
            Tag tag = (Tag)obj;

            while (true)
            {
                var value = plcSimulatorManager.AddressValues[tag.Address];
                if (value != CurrentValues[tag.Id])
                {
                    OnValueChanged(tag.Id, value);
                }

                SetNewValue(tag, value);
            }
        }

        private void SetNewValue(Tag tag, double value)
        {
            CurrentValues[tag.Id] = value;

            if (tag is InputTag)
            {
                var inputTag = (InputTag)tag;
                Thread.Sleep(inputTag.ScanTime);

                if (tag.GetType() == typeof(AnalogInput))
                {
                    var analogTag = (AnalogInput)tag;
                    if (analogTag.Alarms != null)
                    {
                        CheckAlarms(analogTag.Alarms, analogTag.Id, value);
                    }
                }
            }
        }

        private void CheckAlarms(List<Alarm> alarms, string tagId, double value)
        {
            foreach (var alarm in alarms)
            {
                if (alarm.Type == Alarm.AlarmType.Lower)
                {
                    if (value < alarm.Limit && !Alarms[alarm.Id])
                    {
                        Alarms[alarm.Id] = true; // we have raised an alarm
                        OnAlarmRaised(new AlarmDTO(alarm.Id, tagId, alarm.Message, DateTime.Now));
                    }
                    // alarm was already raised
                    else if (value >= alarm.Limit) { Alarms[alarm.Id] = false; }
                }
                else
                {
                    if (value > alarm.Limit && !Alarms[alarm.Id])
                    {
                        Alarms[alarm.Id] = true; // we have raised an alarm
                        OnAlarmRaised(new AlarmDTO(alarm.Id, tagId, alarm.Message, DateTime.Now));
                    }
                    // alarm was already raised
                    else if (value <= alarm.Limit) { Alarms[alarm.Id] = false; }
                }
            }
        }

        private void OnValueChanged(string id, double value)
        {
            ValueChangedHandler?.Invoke(id, value);
        }

        private void OnAlarmRaised(AlarmDTO alarmRaised)
        {
            // write alarm to database
            DbContext.Alarms.Add(alarmRaised);
            try
            {
                DbContext.SaveChanges();
            }
            catch { }
            // notify the client
            AlarmHandler?.Invoke(alarmRaised.AlarmId);
        }
    }
}
