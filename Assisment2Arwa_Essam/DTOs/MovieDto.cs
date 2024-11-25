using Assisment2Arwa_Essam.Models;

namespace Assisment2Arwa_Essam.DTOs
{
    public class MovieDto
    {
        public string Title { get; set; }
        public DateTime ReleaseYear { get; set; }
        public Category Category { get; set; }
        public Cinema Cinema { get; set; }
    }
}
