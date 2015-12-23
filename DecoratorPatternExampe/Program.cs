using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Beverage beverage = new Expresso();

            Console.WriteLine(string.Format("{0}, ${1}", beverage.getDescription(),beverage.cost()));
            Console.ReadLine();


            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2) ;

            Console.WriteLine(string.Format("{0}, ${1}", beverage2.getDescription(), beverage2.cost()));
            Console.ReadLine();

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Mocha(beverage3);
            beverage3 = new Soy(beverage3);
            beverage3 = new Whip(beverage3);

            Console.WriteLine(string.Format("{0}, ${1}", beverage3.getDescription(), beverage3.cost()));
            Console.ReadLine();
        }
    }
}
