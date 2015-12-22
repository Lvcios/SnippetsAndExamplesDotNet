using KaratedocaStrategyExample.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaratedocaStrategyExample.Speak
{
    public class Kata : ISpeakBehavior
    {
        public void Speak(string _word)
        {
            Console.WriteLine("Kata! : " + _word);
        }
    }
}
