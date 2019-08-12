using Microsoft.AspNetCore.Mvc;
using ResumeData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeWebSite.Controllers
{
    public class HomeController : Controller
    {
        private ITag _tag;
        private IProject _project;

        public HomeController(ITag tag, IProject project)
        {
            _tag = tag;
            _project = project;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
