using System;

namespace Transformers
{
    internal partial class Program
    {
        public class Starscream : FlyingTransformer
        {
            public Starscream() { }

            public override string Name => "Starscream";

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

            public override void Fly()
            {
                Console.WriteLine("The transformer is moving");
            }
        }
    }
}