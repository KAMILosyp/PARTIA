namespace PARTIA
{
    public class PoliticalPartyInMemory : PoliticalPartyBase
    {
        public override event SupportAddedDelegate SupportAdded;

        private List<float> support = new List<float>();

        public PoliticalPartyInMemory(string name)
            : base(name)
        {
        }

        public override void AddSupport(float support)
        {
            if (support > 0)
            {
                this.support.Add(support);
            }
            if (SupportAdded != null)
            { 
                SupportAdded(this, new EventArgs());

            }
            else
            {
                throw new Exception("Invalid support value");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var support in this.support)
            {
                statistics.AddSupport(support);
            }

            return statistics;
        }

    }

}