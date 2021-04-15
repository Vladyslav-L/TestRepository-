using System;
using System.Threading;
using static Transformers.Program;

namespace Transformers
{
    internal class Fight
    {
        public void Play(Transformer transformer1, Transformer transformer2)
        {
            while (transformer1.Healthpoint > 0 && transformer2.Healthpoint > 0)
            {
                Random random = new Random();
                var randomValue = random.Next(0, 2);

                if (randomValue == 0)
                {
                    Console.WriteLine($"Healthpoint {transformer2.Name}, {transformer2.Healthpoint}");
                    transformer2.Healthpoint -= transformer1.Fire();
                    Console.WriteLine($"Damage give {transformer1.Name}, {transformer1.Fire()}");
                    Console.WriteLine($"Healthpoint {transformer2.Name}, {transformer2.Healthpoint}");
                    Thread.Sleep(500);
                }
                else
                {
                    Console.WriteLine($"Healthpoint {transformer1.Name}, {transformer1.Healthpoint}");
                    transformer1.Healthpoint -= transformer2.Fire();
                    Console.WriteLine($"Damage give {transformer2.Name}, { transformer2.Fire()}");
                    Console.WriteLine($"Healthpoint {transformer1.Name}, {transformer1.Healthpoint}");
                    Thread.Sleep(500);
                }

                if (transformer1.Healthpoint <= 0)
                {
                    Console.WriteLine($"{transformer1.Name} lose {transformer2.Name} Healthpoint{transformer2.Healthpoint},  {transformer1.Name} Healthpoint{transformer1.Healthpoint}");
                }

                if (transformer2.Healthpoint <= 0)
                {
                    Console.WriteLine($"{transformer2.Name} lose {transformer1.Name} Healthpoint{transformer1.Healthpoint},  {transformer2.Name} Healthpoint{transformer2.Healthpoint}");
                }
            }
        }
    }
}



