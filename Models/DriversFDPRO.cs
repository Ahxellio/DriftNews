using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriftNewsParser.Models
{
    public class DriversFDPRO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string CarName { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public string Age { get; set; }
        [Required]
        public string Sponsors { get; set; }
        [Required]
        public string Hometown { get; set; }

        public string Team { get; set; }
        [Required]
        public string Href { get; set; }

        [Required]
        public string ImgSrc { get; set; }

        [Required]
        public string Championship { get; set; }
    }
}
