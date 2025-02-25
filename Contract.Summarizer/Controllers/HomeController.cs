using Microsoft.AspNetCore.Mvc;
using Summarizer.DataAccess.Repository.IRepository;
using Summarizer.Models;
using System.Diagnostics;

namespace Contract.Summarizer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {

            List<Form> formdb = _unitOfWork.forms.GetAll().ToList();
            if (formdb != null)
            {
                return View(formdb);
            }
            return View(NotFound());
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

