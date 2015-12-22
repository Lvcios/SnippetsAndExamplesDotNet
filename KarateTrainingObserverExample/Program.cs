using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarateTrainingObserverExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Sensei _sensei = new Sensei();

            Student _student1 = new Student(_sensei);
            Student _student2 = new Student(_sensei);
            Student _student3 = new Student(_sensei);

            Console.WriteLine("El profesor ejecutará una técnica");
            _sensei.ExecuteInstruction("Patada");
            Console.WriteLine("El profesor ha ejecutado una técnica, ahora los alumnos la tiene que replicar.");
            _sensei.Notify();
            Console.WriteLine("Un alumno ha decido abandonar la practica. Ahora solo dos alumnos ejecutaran la técnica");
            _sensei.Remove(_student1);
            _sensei.ExecuteInstruction("Patada");
            _sensei.Notify();
            Console.ReadLine();

        }
    }
}
