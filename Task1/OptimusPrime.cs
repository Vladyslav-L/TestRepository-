using System;

namespace Transformers
{
    internal partial class Program
    {
        public class OptimusPrime : DriverTransformer
        {
            public OptimusPrime() { }

            public override string Name => "OptimusPrime";

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