using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Data;
using RunGroopWebApp.Interface;
using RunGroopWebApp.Models;
using RunGroopWebApp.Repository;
using RunGroopWebApp.Services;
using RunGroopWebApp.ViewModels;

namespace RunGroopWebApp.Controllers
{
    public class RaceController : Controller
    {
        
        private readonly IRaceRepository _raceRepository;
        private readonly IPhotoService _photoService;

        public RaceController(IRaceRepository raceRepository, IPhotoService photoService)
        {
            
            _raceRepository = raceRepository;
            _photoService = photoService;
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

        public async Task<IActionResult> Create(CreateRaceViewModel RaceVm)
        {
            if (ModelState.IsValid)
            {
                var result = await _photoService.AddphotoAsync(RaceVm.Image);

                var race = new Race
                {

                    Title = RaceVm.Title,
                    Description = RaceVm.Description,
                    Image = result.Url.ToString(),
                    Address = new Address
                    {
                        Street = RaceVm.Address.Street,
                        City = RaceVm.Address.City,
                        State = RaceVm.Address.State,
                    }
                };

                _raceRepository.Add(race);
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "photo upload failed");
            }
            return View(RaceVm);
        }
    
    }
}
