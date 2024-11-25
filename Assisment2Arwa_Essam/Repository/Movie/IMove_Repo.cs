using Assisment2Arwa_Essam.DTOs;

namespace Assisment2Arwa_Essam.Repository.Movie
{
    public interface IMove_Repo
    {
        public List<MovieDto> GetMovies();
        public MovieDto GetById (int id);
        public void AddMovie (MovieDto movie);

    }
}
