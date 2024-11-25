using Assisment2Arwa_Essam.Data;
using Assisment2Arwa_Essam.DTOs;
using Assisment2Arwa_Essam.Models;
using Microsoft.EntityFrameworkCore;

namespace Assisment2Arwa_Essam.Repository.Cinema
{
    public class Cinema_Repo : ICenemaRepo
    {

        public Cinema_Repo(AppDbContext context)
        {
            context = _context;
        }
        protected readonly AppDbContext _context;


        public void AddCinema(CinemaDto cinemaDto)
        {
            var cinema = new CinemaDto
            {
                C_Name = cinemaDto.C_Name,
                PlaceHolder = cinemaDto.PlaceHolder,
                Movies = cinemaDto.Movies.Select(x => new MovieDto
                {
                    Title = x.Title,
                    ReleaseYear = x.ReleaseYear,
                    Category = new Category
                    {
                      Name = x.Category.Name,
                    }
                }).ToList(),
            };
            _context.Add(cinema);
            _context.SaveChanges();
        }

        public List<CinemaDto> GetAll()
        {
            var res = _context.Cinema.Include(x => x.Movies).
                ThenInclude(x => x.Category).Select(x => new CinemaDto
                {
                C_Name = x.C_Name,
                PlaceHolder = x.PlaceHolder,
                Movies = x.Movies.Select(x => new MovieDto
                {
                    Title = x.Title,
                    ReleaseYear = x.ReleaseYear,
                    Category = new Category
                        {
                        Name = x.Category.Name,
                    },

                }).ToList()
            } );
            return res.ToList();
        }



        public void UpdateAll(CinemaDto cinemaDto, int id)
        {
            var res = _context.Cinema.Include(x => x.Movies).
                ThenInclude(x => x.Category).FirstOrDefault(x=>x.C_Id == id);
            res.C_Name = cinemaDto.C_Name;
            res.PlaceHolder = cinemaDto.PlaceHolder;
            res.Movies = cinemaDto.Movies.Select(x=>new Models.Movie
            {
                Title = x.Title,
                ReleaseYear = x.ReleaseYear,
                Category = new Category { Name = x.Category.Name, },
            }).ToList();
               _context.Cinema.Update(res);
            _context.SaveChanges();
            
        }
    }
}
