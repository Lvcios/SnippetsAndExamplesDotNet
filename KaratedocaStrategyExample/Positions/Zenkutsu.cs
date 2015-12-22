using KaratedocaStrategyExample.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaratedocaStrategyExample.Positions
{
    
    public class Zenkutsu : IPositionBehavior
    {
        public void DoPosition()
        {
            Console.WriteLine("Se estira la pierna hacia donde se hace el movimiento de tal manera que la distancia entre los dos pies sea aproximadamente el doble que hay en la posición de naute");
        }
    }
}
