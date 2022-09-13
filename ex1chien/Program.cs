using System;

namespace Porgram
{
    internal class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Hello world");
            Chien monChien = new Chien("Medor", "Waf");
            Console.WriteLine(monChien.ToString());
        }
    }
}