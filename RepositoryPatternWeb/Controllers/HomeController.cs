using RepositoryPatternWeb.Models;
using RepositoryPatternWeb.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepositoryPatternWeb.Controllers
{
    public class HomeController : Controller
    {
        private IPlanetRepository _planetRepository;
        public HomeController()
        {
            this._planetRepository = new PlanetRepository();
        }

        public HomeController(IPlanetRepository planetRepository)
        {
            this._planetRepository = planetRepository;
        }
        // GET: Home
        [OutputCache(Duration = 10)]
        public ActionResult Index()
        {
            _planetRepository.List();
            return View(_planetRepository.List());
        }
    }
}