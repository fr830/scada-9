using DataConcentrator.Model;

namespace DataConcentrator
{
    public class DigitalInput: InputTag
    {
        public DigitalInput()
        {

        }

        public DigitalInput(string id, string description, string address, int scanTime) : base (id, description, address, scanTime)
        {
        }
    }
}
