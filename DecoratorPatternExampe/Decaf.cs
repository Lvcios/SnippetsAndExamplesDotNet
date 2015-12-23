using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf cafe";
        }

        public override double cost()
        {
            return .5;
        }
    }
}
