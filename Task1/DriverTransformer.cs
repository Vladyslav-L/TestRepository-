namespace Transformers
{
    internal partial class Program
    {
        public abstract class DriverTransformer : Transformer
        {
            public DriverTransformer() { }/*(Weapon weapon, Scanner scanner) : base(weapon, scanner) { }*/

            public abstract void Drive();
        }
    }
}