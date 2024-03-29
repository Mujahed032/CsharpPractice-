﻿using RunGroopWebApp.Models;

namespace RunGroopWebApp.Interface
{
    public interface IClubRepository
    {
        Task<IEnumerable<Club>> GetAll();

        Task<Club> GetByIdAsyn(int id);

        Task<IEnumerable<Club>> GetClubByCity(string city);

        bool Add(Club club);

        bool Update(Club club);

        bool Delete(Club club);

        bool Save();
    }
}
