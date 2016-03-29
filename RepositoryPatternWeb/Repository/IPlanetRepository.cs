using RepositoryPatternWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWeb.Repository
{
    public interface IPlanetRepository:IRepository<Planet>
    {
        List<Planet> List(int id, string filtro, string filtro2, string filtro3);
    }
}
