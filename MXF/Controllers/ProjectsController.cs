using MXF.Models;
using MXF.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MXF.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Projects

        public ActionResult Index()
        {
            return View();
        }
        [Route("projects/test/{status}")]
        public ActionResult Test(int status)
        {
            ProjectsRepo p = new ProjectsRepo();
            List<ProjectData> prs = p.GetProjectsByStatus(status);

            return View(prs);
        }
    }
}