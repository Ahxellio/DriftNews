using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriftNews.Models
{
    public class Driver
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Car { get; set; }
        [Required]
        public string Number { get; set; }
        public string Team { get; set; }

        public string Href { get; set; }

        [Required]
        public string ImgSrc { get; set; }

        [ForeignKey(nameof(Championship))]
        public int ChampionshipId { get; set; }
        [Required]
        public Championship Championship { get; set; }

    }
}
