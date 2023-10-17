

namespace PARTIA
{
    public class PoliticalPartyInFile : PoliticalPartyBase
    {
        private const string fileName = "supports.txt";

        public override event SupportAddedDelegate SupportAdded;

        public PoliticalPartyInFile(string name)
            : base(name)
        {
        }

        public override void AddSupport(float support)
        {
            if (support > 0)
            {

                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(support);
                }
                if (SupportAdded != null)
                {
                    SupportAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid support value");
            }
        }
        public override Statistics GetStatistics()

        {
            var statistics = new Statistics();

            var supportsFromFile = this.ReadSupportFromFile();

            foreach (var support in supportsFromFile)
            {
                statistics.AddSupport(support);
            }
            return statistics;
        }

        private List<float> ReadSupportFromFile()

        {

            var supports = new List<float>();
            if (File.Exists($"{fileName}"))
            {

                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        supports.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return supports;
        }
    }
}

