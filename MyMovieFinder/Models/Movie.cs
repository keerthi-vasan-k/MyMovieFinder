using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMovieFinder.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string MovieName { get; set; }

        [Required]
        [StringLength(100)]
        public string Genre { get; set; }

        public double Rating { get; set; }

        [Required]
        [StringLength(255)]
        public string Director { get; set; }

        [StringLength(255)]
        public string Actor { get; set; }

        public short Year { get; set; }
    }
}
