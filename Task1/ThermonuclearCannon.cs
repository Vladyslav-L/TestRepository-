using System;

namespace Transformers
{
    internal partial class Program
    {
        public class ThermonuclearCannon : Weapon
        {
             protected int Count;



            public override void Reload()
            {
                Console.WriteLine("Im Reload");
                Ammo = 100;                
            }

            public override int Fire()
            {
                Random random = new Random();
                var damege = random.Next(5, 26);

                if (Count / 3 == 0)
                {                  
                    damege = damege * 4;                    
                }   

                Count++;
                return damege;                 
            }
        }

    }
}