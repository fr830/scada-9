
namespace DataConcentrator.Model
{
    public abstract class OutputTag: Tag
    {
        public OutputTag()
        {

        }

        public OutputTag(string id, string description, string address, double initialValue) : base(id, description, address)
        {
            this.initialValue = initialValue;
        }

        private double initialValue;

        public double InitialValue
        {
            get { return initialValue; }
            set { initialValue = value; }
        }
    }
}
