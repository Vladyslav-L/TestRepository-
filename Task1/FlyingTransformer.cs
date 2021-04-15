namespace Transformers
{
    internal partial class Program
    {
        public abstract class FlyingTransformer : Transformer
        {
            protected FlyingTransformer() { } 

            public abstract void Fly();
        }
    }
}