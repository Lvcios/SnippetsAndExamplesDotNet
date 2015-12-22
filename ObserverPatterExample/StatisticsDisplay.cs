using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatterExample
{
    public class StatisticsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject wheaterData;

        public StatisticsDisplay(Subject wheaterData)
        {
            //this.wheaterData = wheaterData;
            wheaterData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine(string.Format("Statistics: {0} temperature F° and {1}& humidity", this.temperature, this.humidity));
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }
    }
}
