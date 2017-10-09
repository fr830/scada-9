
namespace DataConcentrator.Model
{
    public abstract class InputTag: Tag
    {
        public InputTag()
        {

        }

        public InputTag(string id, string description, string address, int scanTime) : base(id, description, address)
        {
            this.scanTime = scanTime;
        }

        private int scanTime;

        public int ScanTime
        {
            get { return scanTime; }
            set { scanTime = value; }
        }
    }
}
