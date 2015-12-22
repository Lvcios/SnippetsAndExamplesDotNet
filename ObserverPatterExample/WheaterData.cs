using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatterExample
{
    public class WheaterData : Subject
    {
        private List<Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;
    
        public WheaterData()
        {
            observers = new List<Observer>();
        }


        public void NotifyObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.Update(this.temperature, this.humidity, this.pressure);
            }
        }

        public void RegisterObserver(Observer o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.RemoveAt(i);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
        
    }
}
