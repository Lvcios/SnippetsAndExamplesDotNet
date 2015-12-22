using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarateTrainingObserverExample
{
    public class Sensei : ISubject
    {
        List<IObserver> Students;
        string ActionName;


        public Sensei()
        {
            Students = new List<IObserver>();
            ActionName = "";
        }

        public void Notify()
        {
            //throw new NotImplementedException();
            foreach(IObserver student in Students)
            {
                student.Update(this.ActionName);
            }
            
        }

        public void Register(IObserver o)
        {
            Students.Add(o);
        }

        public void Remove(IObserver o)
        {
            Students.Remove(o);
        }

        public void ExecuteInstruction(string action)
        {
            Console.WriteLine(string.Format("El profesor ha realizado la técnica: {0}", action));
            this.ActionName = action;
        }
    }
}
