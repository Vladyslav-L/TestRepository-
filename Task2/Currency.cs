public class Currency
{
    public string Name { get; set; }

    public double Value { get; set; }

    public Currency(string name, double value)
    {
        Name = name;
        Value = value;
    }

    public override string ToString()
    {
        return $"{Name} {Value}$";
    }
}