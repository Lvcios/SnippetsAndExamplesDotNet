using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var connorKiller = new Robot();
            connorKiller.Disparador = new DispararNormal();
            connorKiller.Caminador = new CaminarDeMedioLado();

            connorKiller.Caminador.Caminar();
            connorKiller.Disparador.Disparar();

            Console.WriteLine("Hell yeah!");
            Console.ReadLine();

            Console.WriteLine("No es muy efectivo, mejor correr. Presiona una tecla!");
            Console.ReadLine();
            connorKiller.Caminador = new CaminarAPropulsion();
            connorKiller.Disparador = new DispararAmetralladora();

            connorKiller.Caminador.Caminar();
            connorKiller.Disparador.Disparar();

            Console.WriteLine("Parece que Connor morirá");
            Console.ReadLine();

            connorKiller.Caminador.Caminar();
            connorKiller.Disparador.Disparar();

            connorKiller.MatarAJohnConnor();
        }
    }
}
