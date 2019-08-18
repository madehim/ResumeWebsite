using ResumeData.Models;
using System.Collections.Generic;

namespace ResumeWebSite.Models.Project
{
    public class ProjectDetailModel
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectGitHubLink { get; set; }
        public Video ProjectVideo { get; set; }

        public IEnumerable<Tag> Tags { get; set; }
        public IEnumerable<Picture> Pictures { get; set; }
    }
}
