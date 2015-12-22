using KaratedocaStrategyExample.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaratedocaStrategyExample.Defenses
{
    public class GedanBarai : IDefenseBehavior
    {
        public void DoDefense()
        {
            Console.WriteLine("Se lleva la mano hacia el hombro contrario y se deja caer con inclinación sobre la pierna que se estira,");
        }
    }
}
