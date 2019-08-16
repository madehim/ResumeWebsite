using Microsoft.AspNetCore.Mvc;
using ResumeData;
using ResumeWebSite.Models.Project;
using System.Linq;

namespace ResumeWebSite.Controllers
{
    public class HomeController : Controller
    {
        private IProject _project;

        public HomeController(IProject project)
        {
            _project = project;
        }


        public IActionResult Index()
        {
            var projects = _project.GetThreeOrLess()
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

        public IActionResult About()
        {
            return View();
        }
    }
}
