using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark roast coffe";
        }

        public override double cost()
        {
            return 2.0;
        }
    }
}
