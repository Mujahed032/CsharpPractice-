using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Data;
using RunGroopWebApp.Interface;
using RunGroopWebApp.Models;

namespace RunGroopWebApp.Controllers
{
    public class RaceController : Controller
    {
        
        private readonly IRaceRepository _raceRepository;

        public RaceController(IRaceRepository raceRepository)
        {
            
            _raceRepository = raceRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Race> races = await _raceRepository.GetAll();
            return View(races);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Race Race = await _raceRepository.GetByIdAsync(id);
            return View(Race);
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Create(Race race)
        {
            if(!ModelState.IsValid)
            {
                return View(race);
            }
            _raceRepository.Add(race);
            return RedirectToAction("Index");
        }
    }
}
