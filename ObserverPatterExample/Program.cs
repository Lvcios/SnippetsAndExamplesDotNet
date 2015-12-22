using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            WheaterData wheaterData = new WheaterData();

            CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay(wheaterData);
            StatisticsDisplay statisticDisplay = new StatisticsDisplay(wheaterData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(wheaterData);
            wheaterData.SetMeasurements(80, 65, 30.4f);
            wheaterData.RemoveObserver(currentDisplay);

            Console.WriteLine("----------------- After remove current display observer -------------------------------");

            wheaterData.SetMeasurements(80, 60, 28.4f);
            Console.ReadLine();
        }
    }
}
