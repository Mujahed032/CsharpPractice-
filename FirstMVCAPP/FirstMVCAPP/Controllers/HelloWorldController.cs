using FirstMVCAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCAPP.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel Doggo = new DogViewModel()
            { Name = "Sif", Age = 2};

            return View(Doggo);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
