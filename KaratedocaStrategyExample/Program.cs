using KaratedocaStrategyExample.Positions;
using KaratedocaStrategyExample.Speak;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaratedocaStrategyExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Karateca _lucio = new Karateca();

            _lucio.Position = new Positions.Misubi();
            _lucio.DoPosition();
            _lucio.Speak = new Salute();
            _lucio.SpeakSomething("Oss!");

            _lucio.Speak = new Kata();
            _lucio.SpeakSomething("Heian Nidan!");
            _lucio.Movement = new Movements.Naute();
            _lucio.Move();

            _lucio.Position = new Positions.Zenkutsu();
            _lucio.DoPosition();
            _lucio.DefenseTechnique = new Defenses.GedanBarai();
            _lucio.Defense();
            Console.WriteLine("Ese el primer movimiento de heian nidan!");

            Console.ReadLine();
        }
    }
}
