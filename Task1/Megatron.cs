using System;

namespace Transformers
{
    internal partial class Program
    {
        public class Megatron : DriverTransformer
        {
            public Megatron() { }

            public override string Name => "Megatron";

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
                    Console.WriteLine("Transformation, Peace through tyranny.");

                }
            }

            public override void Drive()
            {
                Console.WriteLine("The transformer is moving");
            }
        }

    }
}