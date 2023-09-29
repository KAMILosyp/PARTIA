

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
        public abstract void AddSupport(string support);

        public abstract void AddSupport(int support);

        public abstract void AddSupport(double support);

        public abstract Statistics GetStatistics();
    }
}
