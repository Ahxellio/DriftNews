using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriftNews.Models
{
    public class NewsDMEC
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Url { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string ImgUrl { get; set; }
        [Required]
        public string Championship { get; set; }
    }
}
