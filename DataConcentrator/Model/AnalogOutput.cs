using DataConcentrator.Model;

namespace DataConcentrator
{
    public class AnalogOutput: OutputTag
    {
        public AnalogOutput()
        {

        }

        public AnalogOutput(string id, string description, string address, double initialValue, string unit): base(id, description, address, initialValue)
        {
            this.unit = unit;
        }

        private string unit;

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
    }
}
