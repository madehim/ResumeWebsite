using System.ComponentModel.DataAnnotations;

namespace ResumeData.Models
{
    public class Video
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string YoutubeLink { get; set; }
    }
}
