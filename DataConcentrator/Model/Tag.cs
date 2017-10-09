using System.Xml.Serialization;

namespace DataConcentrator
{
    [XmlInclude(typeof(DigitalInput))]
    [XmlInclude(typeof(DigitalOutput))]
    [XmlInclude(typeof(AnalogInput))]
    [XmlInclude(typeof(AnalogOutput))]
    public abstract class Tag
    {
        public Tag()
        {

        }

        public Tag(string id, string description, string address)
        {
            this.id = id;
            this.description = description;
            this.address = address;
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }


        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

    }
}
