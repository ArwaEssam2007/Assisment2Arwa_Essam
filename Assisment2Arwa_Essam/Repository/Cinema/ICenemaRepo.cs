using Assisment2Arwa_Essam.DTOs;

namespace Assisment2Arwa_Essam.Repository.Cinema
{
    public interface ICenemaRepo
    {
        public List<CinemaDto> GetAll();
        public void AddCinema(CinemaDto cinemaDto);
       public void UpdateAll (CinemaDto cinemaDto , int id);

    }
}
