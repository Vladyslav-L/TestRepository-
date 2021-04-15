using System;

namespace Transformers
{
    internal partial class Program
    {
        public static void Main(string[] args)
        {
            CreateTransformers();
            Console.WriteLine("( . Y . )");
        }

        public static void CreateTransformers()
        {
            Console.WriteLine("Choose transformer 1: OptimusPrime = 1, Bumblebee = 2, Starscream = 3, Megatron = 4.");
            var inputFirstTransformer = Console.ReadLine();

            Transformer transformer1 = null;

            switch (inputFirstTransformer)
            {
                case "1":
                    transformer1 = new OptimusPrime();
                    break;
                case "2":
                    transformer1 = new Bumblebee();
                    break;
                case "3":
                    transformer1 = new Starscream();
                    break;
                case "4":
                    transformer1 = new Megatron();
                    break;
                default: throw new Exception ("Incorrect action");                   
            }

            Console.WriteLine("Choose weapon: ResonantBlaster = 1, LaserWeapon = 2, ThermonuclearCannon = 3;");
            var inputWeapon = Console.ReadLine();

            switch (inputWeapon)
            {
                case "1":
                    transformer1.Weapon = new ResonantBlaster();
                    break;
                case "2":
                    transformer1.Weapon = new LaserWeapon();
                    break;
                case "3":
                    transformer1.Weapon = new ThermonuclearCannon();
                    break;
                default: throw new Exception("Incorrect action");
            }

            Console.WriteLine("Choose scanner: OpticalScanner = 1, ExoScanner = 2.");
            var inputScanner = Console.ReadLine();

            switch (inputScanner)
            {
                case "1":
                    transformer1.Scanner = new OpticalScanner();
                    break;
                case "2":
                    transformer1.Scanner = new ExoScanner();
                    break;
                default: throw new Exception("Incorrect action");
            }

            Console.WriteLine("Choose transformer 2: OptimusPrime = 1, Bumblebee = 2, Starscream = 3, Megatron = 4.");
            var inputSecondTransformer = Console.ReadLine();

            Transformer transformer2 = null;

            switch (inputSecondTransformer)
            {
                case "1":
                    transformer2 = new OptimusPrime();
                    break;
                case "2":
                    transformer2 = new Bumblebee();
                    break;
                case "3":
                    transformer2 = new Starscream();
                    break;
                case "4":
                    transformer2 = new Megatron();
                    break;
                default: throw new Exception("Incorrect action");
            }

            Console.WriteLine("Choose weapon: ResonantBlaster = 1, LaserWeapon = 2, ThermonuclearCannon = 3.");
            var inputWeapon2 = Console.ReadLine();

            switch (inputWeapon2)
            {
                case "1":
                    transformer2.Weapon = new ResonantBlaster();
                    break;
                case "2":
                    transformer2.Weapon = new LaserWeapon();
                    break;
                case "3":
                    transformer2.Weapon = new ThermonuclearCannon();
                    break;
                default: throw new Exception("Incorrect action");
            }

            Console.WriteLine("Choose scanner: OpticalScanner = 1, ExoScanner = 2.");
            var inputScanner2 = Console.ReadLine();

            switch (inputScanner2)
            {
                case "1":
                    transformer2.Scanner = new OpticalScanner();
                    break;
                case "2":
                    transformer2.Scanner = new ExoScanner();
                    break;
                default: throw new Exception("Incorrect action");
            }

            Console.Write($"{transformer1.Name} "); transformer1.Transform();
            transformer1.FindEnemy();
            transformer1.Run();

            Console.Write($"{transformer2.Name} "); transformer2.Transform();
            transformer2.FindEnemy();
            transformer2.Run();

            Fight fight = new Fight();
            fight.Play(transformer1, transformer2);            
        }
    }
}



