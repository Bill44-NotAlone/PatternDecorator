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
            Beverage beverage1 = new Espresso();
            Console.WriteLine($"{beverage1.GetDescription()} : {beverage1.Cost()}");
            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine($"{beverage2.GetDescription()} : { beverage2.Cost()}");
            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine($"{beverage3.GetDescription()} : {beverage3.Cost()}");
            Console.WriteLine("=============");
            Beverage beverage4 = new Decaf();
            Console.WriteLine(beverage4.GetDescription());
            beverage4 = new Mocha(beverage4);
            Console.WriteLine(beverage4.GetDescription());
            beverage4 = new Milk(beverage4);
            Console.WriteLine(beverage4.GetDescription());
            beverage4 = new Soy(beverage4);
            Console.WriteLine(beverage4.GetDescription());
            beverage4 = new Whip(beverage4);
            Console.WriteLine(beverage4.GetDescription());
            Console.ReadKey();
        }
    }
}
