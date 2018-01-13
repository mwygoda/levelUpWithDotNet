using System.Linq;
using EFloading.Models;

namespace EFloading.Repositories
{
    public class ExplicitRepository
    {
        public FootballTeam GetTeam(int teamNumber)
        {
            using (var context = new FootballContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                var choosenTeam = context.FootballTeams
                                         .FirstOrDefault(t => t.TeamId == teamNumber);
                context.Entry(choosenTeam).Collection(p => p.Players).Load();
                return choosenTeam;
            }
        }
    }
}
