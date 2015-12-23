using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House blend coffe";
        }

        public override double cost()
        {
            return 0.89;
        }
    }
}
