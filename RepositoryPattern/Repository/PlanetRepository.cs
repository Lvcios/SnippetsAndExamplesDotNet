using RepositoryPattern.Model;
using RepositoryPattern.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Repository
{
    public class PlanetRepository : IRepository<Planet>
    {
        public List<Planet> List(params object[] parameters)
        {
            List<Planet> planetList = new List<Planet>();

            // SqlConnection code would actually go here, this is to keep things simple.
            planetList.Add(new Planet(1, "Mercury", false));
            planetList.Add(new Planet(2, "Venus", true));
            planetList.Add(new Planet(3, "Earth", true));
            planetList.Add(new Planet(4, "Mars", true));
            planetList.Add(new Planet(5, "Jupiter", false));
            planetList.Add(new Planet(6, "Saturn", false));
            planetList.Add(new Planet(7, "Uranus", false));
            planetList.Add(new Planet(8, "Neptune", false));
            planetList.Add(new Planet(9, "Pluto", false));

            return planetList;
        }

        public void Delete(int Id)
        {
            
        }

        public Planet GetById(int Id)
        {
            List<Planet> planetList = new List<Planet>();

            // SqlConnection code would actually go here, this is to keep things simple.
            planetList.Add(new Planet(1, "Mercury", false));
            planetList.Add(new Planet(2, "Venus", true));
            planetList.Add(new Planet(3, "Earth", true));
            planetList.Add(new Planet(4, "Mars", true));
            planetList.Add(new Planet(5, "Jupiter", false));
            planetList.Add(new Planet(6, "Saturn", false));
            planetList.Add(new Planet(7, "Uranus", false));
            planetList.Add(new Planet(8, "Neptune", false));
            planetList.Add(new Planet(9, "Pluto", false));

            return planetList.Where(m => m.Id == Id).FirstOrDefault();
        }

        public void Save(Planet entity)
        {
            
        }

        public void Update(Planet entity)
        {
            
        }
    }
}
