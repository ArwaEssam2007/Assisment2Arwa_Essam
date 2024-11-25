using System.ComponentModel.DataAnnotations;

namespace Assisment2Arwa_Essam.Models
{
    public class Cinema
    {
        [Key]
        public int C_Id { get; set; }
        [Required]
        public string C_Name { get; set; }
        [Required]
        public int PlaceHolder { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
