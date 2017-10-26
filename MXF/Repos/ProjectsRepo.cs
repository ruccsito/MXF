using MXF.Entities;
using MXF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MXF.Repos
{
    public class ProjectsRepo
    {
        private MySqlContext db = new MySqlContext();

        public List<ProjectData> GetProjectsByStatus(int status)
        {
            List<ProjectData> p = new List<ProjectData>();

            p = (from pr in db.Project
                        join bu in db.BusinessUnit on pr.belongto_businessunitid equals bu.businessunitid
                        join st in db.Status on pr.statusid equals st.statusid
                        where st.statusid == status
                        orderby pr.lastmodifydate descending
                        select new ProjectData
                        {
                            id = pr.projectid,
                            name = pr.projectname,
                            status = st.status,
                            bu = bu.businessunitname,
                            size = pr.storagesize,
                            lastModify = pr.lastmodifydate
                        }).ToList();

            return p;
        }
        public object GetJsonProjectsByStatus(int status)
        {
            List<List<ProjectData>> rest = new List<List<ProjectData>>();

            List<ProjectData> projects = new List<ProjectData>();

            projects = (from pr in db.Project
                           join bu in db.BusinessUnit on pr.belongto_businessunitid equals bu.businessunitid
                           join st in db.Status on pr.statusid equals st.statusid
                           where st.statusid == status
                           orderby pr.lastmodifydate descending
                           select new ProjectData
                           {
                               id = pr.projectid,
                               name = pr.projectname,
                               status = st.status,
                               bu = bu.businessunitname,
                               size = pr.storagesize,
                               lastModify = pr.lastmodifydate
                           }).ToList();

            var r = from p in projects
                    select new[] {
                        p.id.ToString(),
                        p.name,
                        p.status,
                        p.bu,
                        p.size.ToString(),
                        p.lastModify.ToShortDateString()
                    };


            return new {
                sEcho = 1,
                iTotalRecords = 3,
                iTotalDisplayRecords = 3,
                aaData = r
            };
        }
    }
}