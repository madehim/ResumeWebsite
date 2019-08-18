
namespace ResumeWebSite.Models.Project
{
    public class ProjectAdminModel
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectGitHubLink { get; set; }

        public string Tags { get; set; }
        public string Pictures { get; set; }
    }
}
