namespace Transformers
{
    internal partial class Program
    {
        public abstract class Transformer
        {
            public virtual string Name { get; }
            public Weapon Weapon { get; set;}
            public Scanner Scanner { get; set; }
            protected bool IsTransformed;
            public int Healthpoint = 100;

            public Transformer()//Weapon weapon, Scanner scanner)
            {
                //Weapon = weapon;
                //Scanner = scanner;
            }

             public Transformer(string name)
            {
                Name = name;
            }               

            public abstract int Fire();
            public abstract void Run();
            public abstract void FindEnemy();
            public abstract void Transform();
        }
    }
}