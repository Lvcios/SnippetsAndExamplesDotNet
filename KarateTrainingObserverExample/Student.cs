using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarateTrainingObserverExample
{
    public class Student : IObserver, IExecutable
    {
        string Technique = "";

        public Student(ISubject sensei)
        {
            sensei.Register(this);
        }

        public void ExecuteTechnique()
        {
            Console.WriteLine(string.Format("El alumno ha replicado la técnica {0}", this.Technique));
        }

        public void Update(string action)
        {
            this.Technique = action;
            ExecuteTechnique();
        }
    }
}
