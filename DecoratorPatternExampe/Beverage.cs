using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample
{
    public abstract class Beverage
    {
        public string Description = "Unknow beverage";

        public string getDescription()
        {
            return this.Description;
        }

        public abstract double cost();
    }
}
