using CollectionHierarchy.Core;

namespace CollectionHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
