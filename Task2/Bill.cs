namespace Task2
{
    public class Bill
    {
        public string Name { get; set; }
        public double Sum { get; set; }

        public Bill(string name, double sum)
        {
            Name = name;
            Sum = sum;
        }

        public override string ToString()
        {
            return $"{Name.ToUpper()}: {string.Format("{0:0.00}", Sum)}";
        }
    }
}
