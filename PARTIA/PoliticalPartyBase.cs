namespace PARTIA
{
    public abstract class PoliticalPartyBase : IPoliticalParty
    {
        public delegate void SupportAddedDelegate(object sender, EventArgs args);

        public abstract event SupportAddedDelegate SupportAdded;

        public PoliticalPartyBase(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }

        public abstract void AddSupport(float support);

        public void AddSupport(double support)
        {
            float result = (float)support;
            this.AddSupport(result);
        }
        public  void AddSupport(string support)
        {
            if (float.TryParse(support, out float result))
            {
                this.AddSupport(result);
            }
            else
            {
                throw new Exception("Ivalid support value");
            }
        }
        public void AddSupport(int support)
        {
            float result = (float)support;
            this.AddSupport(result);
        }

        public abstract Statistics GetStatistics();
    }
}
