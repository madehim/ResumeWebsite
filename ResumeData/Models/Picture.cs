using System.ComponentModel.DataAnnotations;

namespace ResumeData.Models
{
    public class Picture
    {

        public int Id { get; set; }
        [Required]
        public string Link { get; set; }
    }
}
