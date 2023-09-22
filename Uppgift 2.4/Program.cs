using System;

namespace Uppgift_2._4
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Mata in lönen för 3 anställda");
            double x = double.Parse(Console.ReadLine());
            
            
            double y = double.Parse(Console.ReadLine());
            
            double z = double.Parse(Console.ReadLine());

            double medellön = (x + y + z) / 3;

            Console.WriteLine("Medellönen för de anställda blir " + medellön + "kr");
            Console.ReadKey();


            
        }
    }
}
