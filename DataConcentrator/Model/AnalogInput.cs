using DataConcentrator.Model;
using System.Collections.Generic;

namespace DataConcentrator
{
    public class AnalogInput: InputTag
    {
        public AnalogInput()
        {
            this.alarms = new List<Alarm>();
        }

        public AnalogInput(string id, string description, string address, int scanTime, string unit): base(id, description, address, scanTime)
        {
            this.unit = unit;
            this.alarms = new List<Alarm>();
        }

        private List<Alarm> alarms;

        public List<Alarm> Alarms
        {
            get { return alarms; }
            set { alarms = value; }
        }

        private string unit;

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
    }
}
