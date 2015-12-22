using StrategyPatternExample.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    public class Robot
    {
        protected IAttackBehavior _disparador;
        protected IMovementBehavior _caminador;

        public IAttackBehavior Disparador
        {
            get { return _disparador; }
            set { _disparador = value; }
        }

        public IMovementBehavior Caminador
        {
            get { return _caminador; }
            set { _caminador = value; }
        }

        public Robot()
        {

        }

        public void Caminar()
        {
            _caminador.Caminar();
        }

        public void Disparar()
        {
            _disparador.Disparar();
        }
        
        public void MatarAJohnConnor() { }
        
    }
}
