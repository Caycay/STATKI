using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Battle.Models;

namespace Battle.Controllers
{
    public class LogController : Controller
    {
        // GET: Log
        public ActionResult Login(string player1, string player2)
        {
            if(string.IsNullOrEmpty(player1)==false && string.IsNullOrEmpty(player1) == false)
            {
                using (var db = new BattleShip())
                {
                    db.Database.ExecuteSqlCommand("TRUNCATE TABLE [Players]");
                    db.Database.ExecuteSqlCommand("TRUNCATE TABLE [Fields]");
                    db.Players.Add(new Player {Name = player1});
                    db.Players.Add(new Player { Name = player2 });
                    db.SaveChanges();
                }
                return RedirectToAction("ShowMap", "Game");
            }
            return View();
        }
    }
}