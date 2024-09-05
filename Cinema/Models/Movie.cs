using System.ComponentModel.DataAnnotations;

namespace Cinema.Models
{
	public class Movie
	{
        [Key]
        public int Id { get; set; }
        [Required, MinLength(30), MaxLength(100)]
        public string Title { get; set; }
        [Required, MinLength(5), MaxLength(50)]
        public string Director { get; set; }
        [Required, MinLength(30), MaxLength(50)]
        public string Genre { get; set; }

		public List<Session> Sessions { get; set; }
    }
}
