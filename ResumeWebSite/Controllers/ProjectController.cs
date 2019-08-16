using Microsoft.AspNetCore.Mvc;
using ResumeData;
using ResumeWebSite.Models.Project;
using System.Linq;

namespace ResumeWebSite.Controllers
{
    public class ProjectController : Controller
    {
        private IProject _project;

        public ProjectController(IProject project)
        {
            _project = project;
        }

        public IActionResult Index()
        {
            var projects = _project.GetAll()
                .Select(project => new ProjectDetailModel
                {
                    Id = project.Id,
                    ProjectName = project.ProjectName,
                    Pictures = project.Pictures,
                    Tags = project.Tags
                });

            var model = new ProjectIndexModel()
            {
                Projects = projects
            };
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var project = _project.Get(id);

            var model = new ProjectDetailModel
            {
                Id = project.Id,
                ProjectName = project.ProjectName,
                ProjectDescription = project.ProjectDescription,
                Pictures = project.Pictures,
                ProjectGitHubLink = project.ProjectGitHubLink,
                Tags = project.Tags
            };

            return View(model);
        }

    }
}
