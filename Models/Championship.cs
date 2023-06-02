using System.ComponentModel.DataAnnotations;
using DriftNews.Data.Enum;

namespace DriftNews.Models
{
    public class Championship
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public ChampionshipCategory Name { get; set; }    }
}
