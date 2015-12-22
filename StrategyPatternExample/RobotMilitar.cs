﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    public class RobotMilitar : Robot
    {
        public RobotMilitar()
        {
            _disparador = new DispararAmetralladora();
            _caminador = new CaminarDeMedioLado();
        }
    }
}
