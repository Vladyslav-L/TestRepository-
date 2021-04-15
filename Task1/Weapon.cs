using System;

namespace Transformers
{
    internal partial class Program
    {
        public abstract class Weapon
        {
            protected int Ammo = 100;   

            public abstract void Reload();
            public abstract int Fire();
        }
    }
}