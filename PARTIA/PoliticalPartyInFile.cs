

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
            if (support > 0 && support <= float.MaxValue)
            {

                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(support);
                    if (SupportAdded != null)
                    {
                        SupportAdded(this, new EventArgs());
                    }
                }
            }
            else
            {
                throw new Exception("Invalid support value");
            }
        }
        public override void AddSupport(double support)
        {
            float result = (float)support;
            this.AddSupport(result);
        }
        public override void AddSupport(string support)
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
        public override void AddSupport(int support)
        {
            float result = (float)support;
            this.AddSupport(result);
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            var supportFromFile = this.ReadSupportFromFile();

            foreach (var support in supportFromFile)
            {
                statistics.AddSupport(support);
            }
            return statistics;
        }

        private List<float> ReadSupportFromFile()
        {
            var support = new List<float>();
            if (File.Exists($"(fileName)"))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        support.Add(number);
                        line = reader.ReadLine();

                    }
                }
            }
            return support;
        }
    }
}

