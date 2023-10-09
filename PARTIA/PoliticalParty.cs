using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace PARTIA
{
    public class PoliticalParty
    {
        private List<float> support = new List<float>();

        public PoliticalParty(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }
    }
}
