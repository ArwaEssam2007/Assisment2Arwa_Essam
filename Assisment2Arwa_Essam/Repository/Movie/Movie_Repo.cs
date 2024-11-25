using Assisment2Arwa_Essam.Data;
using Assisment2Arwa_Essam.DTOs;
using Assisment2Arwa_Essam.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assisment2Arwa_Essam.Repository.Movie
{
    public class Movie_Repo : IMove_Repo
    {
        protected readonly AppDbContext _context;

        public Movie_Repo(AppDbContext context)
        {
            _context = context; 
        }

        public List<MovieDto> GetMovies()
        {
            var res = _context.Movies
                .Include(x => x.Category)
                .Include(x => x.Cinema)
                .Select(x => new MovieDto
                {
                    Title = x.Title,
                    ReleaseYear = x.ReleaseYear,
                    Cinema = new Models.Cinema
                    {
                        C_Name = x.Cinema.C_Name,
                    },
                    Category = new Category 
                    { 
                        Name = x.Category.Name
                    }
                }).ToList();
            return res;
        }
        public MovieDto GetById(int id)
        {
            var res = _context.Movies
                .Include(x => x.Category)
                .Include(x => x.Cinema)
                .FirstOrDefault(res => res.Id == id);
            if (res != null)
            {
                return new MovieDto
                {
                    Title = res.Title,
                    ReleaseYear = res.ReleaseYear,
                    Cinema = new Models.Cinema { 
                        C_Name = res.Cinema.C_Name ,
                        PlaceHolder = res.Cinema.PlaceHolder},
                    Category = new Category
                    {
                        Name = res.Category.Name ,
                    }
                };
            }
            return null;
        } 
        public void AddMovie(MovieDto movieDto)
        {
            var mov = new MovieDto
            {
                Title = movieDto.Title,
                ReleaseYear = movieDto.ReleaseYear,
                Category = new Category { Name = movieDto.Category.Name, },
                Cinema = new Models.Cinema
                { C_Name = movieDto.Cinema.C_Name, PlaceHolder = movieDto.Cinema.PlaceHolder
                }

            };
            _context.Movies.Add(mov);
            _context.SaveChanges();
    }
}