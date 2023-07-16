using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RunGroopWebApp.Data;
using RunGroopWebApp.Helpers;
using RunGroopWebApp.Interface;
using RunGroopWebApp.Models;

namespace RunGroopWebApp.Repository
{
    public class ClubRepository : IClubRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IOptions<CloudinarySettings> _options;
        public ClubRepository(ApplicationDbContext context, IOptions<CloudinarySettings> options = null)
        {
            _context = context;
            _options = options;
        }
        public bool Add(Club club)
        {
            _context.Add(club);
            return Save();
        }

        public bool Delete(Club club)
        {
            _context.Remove(club);
            return Save();
        }

        public async Task<IEnumerable<Club>> GetAll()
        {
            return await _context.Clubs.ToListAsync();
            
        }

        public async Task<Club> GetByIdAsyn(int id)
        {
            return await _context.Clubs.Include(a => a.Address).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Club>> GetClubByCity(string city)
        {
           return await _context.Clubs.Where(c => c.Address.City.Contains(city)).ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true: false;
        }

        public bool Update(Club club)
        {
            _context.Update(club);
            return Save();
        }
    }
}
