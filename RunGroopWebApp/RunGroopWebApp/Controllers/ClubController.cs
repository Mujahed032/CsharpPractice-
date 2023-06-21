using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Data;
using RunGroopWebApp.Interface;
using RunGroopWebApp.Models;
using RunGroopWebApp.ViewModels;
using System.Collections;

namespace RunGroopWebApp.Controllers
{
    public class ClubController : Controller
    {
        
        private readonly IClubRepository _clubRepository;
        private readonly IPhotoService _photoService;

        public ClubController(IClubRepository clubRepository, IPhotoService photoService)
        {
            
            _clubRepository = clubRepository;
            _photoService = photoService;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Club> clubs = await _clubRepository.GetAll();
            return View(clubs);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Club club = await _clubRepository.GetByIdAsyn(id);
            return View(club);
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateClubViewModel clubVm)
        {
            if (ModelState.IsValid)
            {
                var result = await _photoService.AddphotoAsync(clubVm.Image);

                var club = new Club {

                    Title = clubVm.Title,
                    Description = clubVm.Description,
                    Image = result.Url.ToString(),
                    Address = new Address
                    {
                        Street = clubVm.Address.Street,
                        City = clubVm.Address.City,
                        State = clubVm.Address.State,
                    }
                 };

                _clubRepository.Add(club);
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "photo upload failed");
            }
           return View(clubVm);
        }
    }
}
