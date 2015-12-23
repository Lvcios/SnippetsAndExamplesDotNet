using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample
{
    public class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage _beverage)
        {
            this.beverage = _beverage;
        }

        public override double cost()
        {
            return this.beverage.cost() + 0.5;
        }

        public override string getDescription()
        {
            return string.Format("{0}, Soy milk", beverage.getDescription());
        }
    }
}
