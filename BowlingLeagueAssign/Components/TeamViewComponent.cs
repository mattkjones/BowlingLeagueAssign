using BowlingLeagueAssign.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingLeagueAssign.Components
{
    public class TeamViewComponent : ViewComponent
    {
        private BowlingLeagueContext context;

        //Constructor
        public TeamViewComponent (BowlingLeagueContext con)
        {
            context = con;
        }

        //Return Team information that will be used to assist in filtering
        public IViewComponentResult Invoke()
        {
            //ViewBag.SelectedTeam = RouteData?.Values["teamname"];

            return View(context.Teams
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
