using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Core.Repository;
using MyPortfolio.Data.Repository;
using MyPortoflio.Core.Entities;
using MyPortoflio.Web.Models;
using MyPortoflio.Web.Models.ViewModel;
using System.Diagnostics;

namespace MyPortoflio.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IunitOfWork<Owner> _owner;
        private readonly IunitOfWork<PortfolioItem> _portfolio;

        public HomeController(ILogger<HomeController> logger,IunitOfWork<Owner> owner,IunitOfWork<PortfolioItem> portfolio)   
        {
            _logger = logger;
            _owner = owner;
            _portfolio = portfolio;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Owner=_owner.Entity.GetAll().First(),   
                PortfolioItems=_portfolio.Entity.GetAll().ToList()   
            };
            return View(homeViewModel); 
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