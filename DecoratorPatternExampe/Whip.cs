using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample
{
    public class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage _beverage)
        {
            this.beverage = _beverage;
        }

        public override double cost()
        {
            return this.beverage.cost() + 0.20;
        }

        public override string getDescription()
        {
            return string.Format("{0}, Whip cream", beverage.getDescription());
        }
    }
}
