using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample.Behaviors
{
    public interface IAttackBehavior
    {
        void Disparar();
        void Golpear();
        void Patear();
        void Barrer();
    }
}
