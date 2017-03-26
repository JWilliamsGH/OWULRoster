using Newtonsoft.Json;
using OWULRoster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OWULRoster.Controllers
{
    public class TeamController : Controller
    {
        public JsonResult GetTeams(int? teamId)
        {
            var context = new RosterDBDataContext();
            var teams = (from t in context.Teams
                         where teamId == null || t.TeamId == teamId
                         orderby t.TeamId
                         select t).Take(100).ToList();
            var json = JsonConvert.SerializeObject(teams, Formatting.Indented, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            return Json(new { teams = json }, JsonRequestBehavior.AllowGet);
        }
    }
}