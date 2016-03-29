using RepositoryPatternWeb.Models;
using RepositoryPatternWeb.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPatternWeb.Business
{
    public class PlanetBusiness
    {
        public PlanetRepository _planetRepository;

        public PlanetBusiness(PlanetRepository _repository)
        {
            _planetRepository = _repository;
        }

        public List<Planet> GetPlanets()
        {
            return _planetRepository.List();
        }
    }
}