using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingLeagueAssign.Models.ViewModels
{
    public class IndexViewModel
    {
        //Used to help us set information in the Home Controller
        public IEnumerable<Bowler> Bowlers { get; set; }
        public PageNumberingInfo PageNumberingInfo { get; set; }
        public string TeamName { get; set; }
    }
}
