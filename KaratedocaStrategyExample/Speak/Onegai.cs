using KaratedocaStrategyExample.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaratedocaStrategyExample.Speak
{
    public class Salute : ISpeakBehavior
    {
        public void Speak(string _word)
        {
            //hablar la palabra enviada en el parametro word
            Console.WriteLine(_word);
        }
    }
}
