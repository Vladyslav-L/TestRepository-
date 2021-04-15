namespace Transformers
{
    internal partial class Program
    {
        public abstract class SwimmingTransformer : Transformer
        {
            protected SwimmingTransformer() { }

            public abstract void Swim();
        }
    }
}