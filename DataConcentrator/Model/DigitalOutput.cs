using DataConcentrator.Model;


namespace DataConcentrator
{
    public class DigitalOutput : OutputTag
    {
        public DigitalOutput()
        {

        }

        public DigitalOutput(string id, string description, string address, double initialValue) : base(id, description, address, initialValue)
        {
        }
    }
}
