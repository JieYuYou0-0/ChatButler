using System;

namespace ChatButler
{
    class Program
    {
        static void Main(string[] args)
        {
            Butler james = new Butler();

            Console.WriteLine(james.Greet());

            Console.ReadKey();
        }
    }
}
