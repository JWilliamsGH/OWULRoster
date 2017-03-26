using Newtonsoft.Json;
using OWULRoster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OWULRoster.Controllers
{
    public class PlayerController : Controller
    {
        [HttpGet]
        public JsonResult GetPlayers(int? playerId)
        {
            var context = new RosterDBDataContext();
            var players = (from p in context.Players
                           where playerId == null || p.PlayerId == playerId
                           orderby p.PlayerId
                           select p).Take(100).ToList();
            var json = JsonConvert.SerializeObject(players, Formatting.Indented, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            return Json(new { players = json }, JsonRequestBehavior.AllowGet);
        }
    }
}