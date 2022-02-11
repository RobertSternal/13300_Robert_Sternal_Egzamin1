using _13300_Robert_Sternal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _13300_Robert_Sternal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private ICrudTravelRepository _repository;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, ICrudTravelRepository repository)
        {
            _logger = logger;
            _context = context;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddForm()
        {
            return View();
        }

        public IActionResult AddTravel(TravelsModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Add(model);
                _context.SaveChanges();
                return RedirectToAction("TravelList");
            }
            else
            {
                return View("AddForm");
            }
        }

        public IActionResult TravelList()
        {
            return View(_repository.FindAll());
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
