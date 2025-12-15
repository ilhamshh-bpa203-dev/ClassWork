using Fiorello.DAL;
using Fiorello.Models;
using Fiorello.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiorello.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDBContext _context;

        public HomeController(AppDBContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            List<Card> cards = _context.Cards.ToList();

            HomeVM homevm = new HomeVM 
            { 
             Sliders = sliders,
            Cards = cards,
            };


            return View(homevm);
        }

    }
}
