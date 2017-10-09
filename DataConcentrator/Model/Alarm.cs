
namespace DataConcentrator
{
    public class Alarm
    {
        public Alarm()
        {

        }

        public Alarm(string id, double limit, string type, string message)
        {
            this.id = id;
            this.limit = limit;
            this.type = type == "Lower" ? AlarmType.Lower : AlarmType.Upper;
            this.message = message;
        }

        public enum AlarmType {
            Lower, Upper
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private double limit;

        public double Limit
        {
            get { return limit; }
            set { limit = value; }
        }

        private AlarmType type;

        public AlarmType Type
        {
            get { return type; }
            set { type = value; }
        }

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}
