using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample
{
    public class Mocha : CondimentDecorator
    {

        Beverage beverage;

        public Mocha(Beverage _beverage)
        {
            this.beverage = _beverage;
        }

        public override double cost()
        {
            return 0.20 + this.beverage.cost();
        }

        public override string getDescription()
        {
            return string.Format("{0}, Mocha", beverage.getDescription());
        }
    }
}
