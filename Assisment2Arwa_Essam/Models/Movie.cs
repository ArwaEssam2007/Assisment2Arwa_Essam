using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assisment2Arwa_Essam.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime ReleaseYear { get; set; }
        [ForeignKey("Category")]
        public int Category_id { get; set; }
        public Category Category { get; set; }

        [ForeignKey("Cinema")]
        public int Cinema_id { get; set; }
        public Cinema Cinema { get; set; }
    }
}
