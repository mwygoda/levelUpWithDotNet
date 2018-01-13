using System.Data.Entity;
using System.Security.Policy;

namespace EFloading.Models
{
    public class FootballContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<FootballTeam> FootballTeams { get; set; }
    }
}
