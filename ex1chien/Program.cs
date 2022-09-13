using System;

namespace Porgram
{
    internal class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Hello world");
            Chien monChien = new Chien("Medor", "Waf", 4);
            Chien monChien2 = new Chien("Fido", "Chiuaua", 5);
            Chien mchien = new Chien("Pupuce", "Yorkshire", 13);

            int age = monChien.getAge() + monChien2.getAge() + mchien.getAge();
            float moyenne = age / Chien.getIstance();
            
            Console.WriteLine("Age moyenne des chiens : " + moyenne + " ans");
            Console.WriteLine(monChien.ToString());
        }
    }
}