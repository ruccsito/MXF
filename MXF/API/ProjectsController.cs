using MXF.Models;
using MXF.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MXF.API
{
    public class ProjectsController : ApiController
    {
        [HttpGet]
        [Route("api/projects/test/{status}")]
        public object Test(int status)
        {
            ProjectsRepo p = new ProjectsRepo();
            return p.GetJsonProjectsByStatus(status);
        }
    }
}
