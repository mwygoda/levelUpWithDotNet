using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFloading.Models
{
    public class FootballTeam
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}
