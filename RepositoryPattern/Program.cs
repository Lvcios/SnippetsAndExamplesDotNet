using RepositoryPattern.Business;
using RepositoryPattern.Model;
using RepositoryPattern.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PlanetBusiness planetBusiness = new PlanetBusiness(new PlanetRepository());

            List<Planet> planetList = planetBusiness.GetPlanets();
            foreach (Planet planet in planetList)
            {
                Console.WriteLine(planet.Id+ ". " + planet.Name);
            }

            Console.ReadLine();
        }
    }
}
