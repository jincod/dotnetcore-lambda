using SimpleLambda;

namespace Lambda.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var functions = new Functions();
            functions.Process(null, null);
        }
    }
}
