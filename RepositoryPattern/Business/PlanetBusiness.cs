using RepositoryPattern.Model;
using RepositoryPattern.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Business
{
    public class PlanetBusiness
    {
        PlanetRepository _planetRepository;

        public PlanetBusiness(PlanetRepository _repository)
        {
            _planetRepository = _repository;
        }

        public List<Planet> GetPlanets()
        {
            return _planetRepository.List(1,2,4);
        }
    }
}
