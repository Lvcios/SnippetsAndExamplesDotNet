using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    public class RobotEstacionario : Robot
    {
        public RobotEstacionario()
        {
            _disparador = new DispararAmetralladora();
            _caminador = new NoCaminar();
        }
    }
}
