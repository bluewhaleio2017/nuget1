using System;
using System.Linq;
using Base.NugetHello;

namespace Base.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin: Base.ConsoleApplication.");
            Example e = new Example();
            e.WriteLicense();
            Console.WriteLine(e.GetMessage());
            Console.WriteLine("");
            Console.WriteLine("End: Base.ConsoleApplication.");
            Console.WriteLine("");
            Console.WriteLine("Press anykey to exit.");
            Console.ReadKey();
        }
    }
}
