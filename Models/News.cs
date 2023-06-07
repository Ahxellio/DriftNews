using System.ComponentModel.DataAnnotations;

namespace DriftNews.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        //[Required]
        //public string Description { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Url { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string ImgUrl { get; set; }

    }
}
