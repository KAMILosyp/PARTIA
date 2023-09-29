
using static PARTIA.PoliticalPartyBase;

namespace PARTIA
{
    public interface IPoliticalParty
    {
        string Name { get; }

        void AddSupport(float support);
        void AddSupport(string support);

        void AddSupport(int support);

        void AddSupport(double support);

        Statistics GetStatistics();

        event SupportAddedDelegate SupportAdded;
    }
}
