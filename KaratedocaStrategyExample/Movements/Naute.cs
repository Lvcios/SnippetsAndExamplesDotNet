using System;
using KaratedocaStrategyExample.Behaviors;

namespace KaratedocaStrategyExample.Movements
{
    public class Naute : IMovementBehavior
    {
        public void DoMovement()
        {
            Console.WriteLine("Se dejan caer los brazos ligeramente inclinados hacia el frente y se separan los pies un poco con los dedos apuntando hacia el frente.");
        }
    }
}