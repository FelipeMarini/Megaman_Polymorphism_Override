using System;
using Megaman_Polymorphism.Classes;

namespace Megaman_Polymorphism
{
    class Program : Player
    {
        static void Main(string[] args)
        {

            string buster = "Buster damage = +10";

            string zSaber = "Zsaber damage = +20";

            Megaman mega = new Megaman();

            Zero zero = new Zero();


            Console.WriteLine();
            Console.WriteLine("MEGAMAN AND ZERO ATTRIBUTES");
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine(mega.Attack());
            Console.WriteLine();
            Console.WriteLine($"{buster}");
            Console.WriteLine();
            Console.WriteLine(mega.Run());
            Console.WriteLine();
            Console.WriteLine(mega.Jump());
            
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(zero.Attack());
            Console.WriteLine();
            Console.WriteLine($"{zSaber}");
            Console.WriteLine();
            Console.WriteLine(zero.Run());
            Console.WriteLine();
            Console.WriteLine(zero.Jump());


        }
    }
}
