using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ResumeData.Models
{
    public class Project
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectGitHubLink { get; set; }
        public Video ProjectVideo { get; set; }

        public virtual IEnumerable<Tag> Tags { get; set; }
        public virtual IEnumerable<Picture> Pictures { get; set; }
    }
}
