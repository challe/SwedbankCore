using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            new AsyncExample().RunAsync().Wait();
        }
    }
}
