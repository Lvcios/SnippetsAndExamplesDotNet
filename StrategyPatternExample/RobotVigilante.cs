using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    public class RobotVigilante : Robot
    {
        public RobotVigilante()
        {
            _disparador = new DispararNormal();
            _caminador = new CaminarNormal();
        }
    }
}
