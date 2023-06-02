using System.ComponentModel.DataAnnotations;

namespace DriftNews.Models
{
    public class Race
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
    }
}
