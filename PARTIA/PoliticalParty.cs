using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace PARTIA
{
    public class PoliticalParty : IPoliticalParty
    {
        private List<float> support = new List<float>();

        public PoliticalParty(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }

        public event PoliticalPartyBase.SupportAddedDelegate SupportAdded;

        public void AddSupport(float support)
        {
            if (support > 0 && support <= float.MaxValue)
            {
                this.support.Add(support);
            }
            else
            {
                throw new Exception("Invalid support value");
            }
        }
        public void AddSupport(double support)
        {
            float result = (float)support;
            this.AddSupport(result);
        }
        public void AddSupport(string support)
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

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            foreach(var support in this.support)
            {
                statistics.AddSupport(support);
            }
            return statistics;
        }

    }

}