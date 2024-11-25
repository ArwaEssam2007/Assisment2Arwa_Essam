using Assisment2Arwa_Essam.Models;
using System.ComponentModel.DataAnnotations;

namespace Assisment2Arwa_Essam.DTOs
{
    public class CinemaDto
    {
        public string C_Name { get; set; }
        public int PlaceHolder { get; set; }
        public List<MovieDto> Movies { get; set; }
    }
}
