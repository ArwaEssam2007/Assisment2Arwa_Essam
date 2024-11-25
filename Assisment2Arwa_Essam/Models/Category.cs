using System.ComponentModel.DataAnnotations;

namespace Assisment2Arwa_Essam.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}                                                                         
