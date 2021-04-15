using System;

namespace Transformers
{
    internal partial class Program
    {
        public class ExoScanner : Scanner
        {
            public override void Scan()
            {
                Console.WriteLine("Scanser is acvivated");
            }
        }
    }
}