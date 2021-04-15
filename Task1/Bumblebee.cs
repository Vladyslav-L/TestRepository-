using System;

namespace Transformers
{
    internal partial class Program
    {
        public class Bumblebee : DriverTransformer
        {
            public Bumblebee() { }

            public override string Name => "Bumblebee";

            public override int Fire()
            {
                return Weapon.Fire();               
            }

            public override void Run()
            {
                if (!IsTransformed)
                {
                    Console.WriteLine("Transformer is running");
                }
            }

            public override void FindEnemy()
            {
                Scanner.Scan();
            }

            public override void Transform()
            {
                if (!IsTransformed)
                {
                    Console.WriteLine("Transformation");
                }
            }

            public override void Drive()
            {
                Console.WriteLine("The transformer is moving");
            }
        }
    }
}