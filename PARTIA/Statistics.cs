namespace PARTIA
{
    public class Statistics
    {
        public float Min { get; private set; }

        public float Max { get; private set; }

        public float Sum { get; private set; }

        public int Count { get; private set; }
        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }
        public void AddSupport(float support)
        {
            this.Count++;
            this.Sum += support;
            this.Min = Math.Min(support, this.Min);
            this.Max = Math.Max(support, this.Max);
        }
        public float Average
        {
            get
            {
                return (this.Sum / this.Count);
            }
        }

    }
}
