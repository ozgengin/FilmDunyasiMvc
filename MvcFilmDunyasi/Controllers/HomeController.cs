using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcFilmDunyasi.Data;
using MvcFilmDunyasi.Models;
using System.Diagnostics;

namespace MvcFilmDunyasi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UygulamaDbContext _db;

        public HomeController(ILogger<HomeController> logger, UygulamaDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index(int? turId)
        {
            IQueryable<Film> filmler = _db.Filmler.Include(x=>x.Turler);

            if(turId != null)
            {
                //öyle filmleri getir ki o filmin türlerinin en az birisinin id 'si turId'ye eşit olsun
                filmler = filmler.Where(x => x.Turler.Any(t => t.Id == turId));
            }

            ViewBag.Turler = _db.Turler.Select(x => new SelectListItem()
            {
                Text = x.Ad,
                Value = x.Id.ToString()
            }).ToList();

            var vm = new HomeViewModel()
            {
                Filmler = filmler.ToList(),
                TurId = turId
            };

            return View(vm);
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