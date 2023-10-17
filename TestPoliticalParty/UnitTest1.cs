using NUnit.Framework;
using PARTIA;

namespace TestPoliticalParty
{
    public class PoliticalPartyTests
    {
        [Test]
        public void WhenSumIsCorrect_ShouldReturnCorrect()
        {
            var PoliticalParty = new PoliticalPartyInMemory("MWD");
            PoliticalParty.AddSupport(4);
            PoliticalParty.AddSupport(32);
            PoliticalParty.AddSupport(1);

            var stat = PoliticalParty.GetStatistics();

            Assert.AreEqual(37, stat.Sum);
            Assert.AreEqual(32, stat.Max);
            Assert.AreEqual(1, stat.Min);
            Assert.AreEqual(12.33d, stat.Average, 2);
        }
    }
}