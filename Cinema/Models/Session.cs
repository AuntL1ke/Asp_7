using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Models
{
	public class Session
	{
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public TimeOnly Time { get; set; }
        [ForeignKey("Movie")]
        public int MovieId { get; set; }

        public Movie Movie { get; set; }
    }
}
