using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorLib;

namespace PatternDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            DarkRoast dark = new DarkRoast();
            Decaf decaf = new Decaf();

            decaf.SetMilk();
            decaf.SetMocha();
            Console.WriteLine($"{decaf.Cost()} - {decaf.GetDescription()}");

            dark.SetMilk();
            dark.SetMocha();
            dark.SetSoy();
            dark.SetWhip();
            Console.WriteLine($"{dark.Cost()} - {dark.GetDescription()}");
            Console.ReadKey();
        }
    }
}
