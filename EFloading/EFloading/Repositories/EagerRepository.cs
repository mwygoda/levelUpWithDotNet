using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EFloading.Models;

namespace EFloading.Repositories
{
    public class EagerRepository
    {
        public List<FootballTeam> GetTeamsWithPlayers()
        {
            using (var context = new FootballContext())
            {
                var result = context.FootballTeams
                                    .Include(x => x.Players)
                                    .ToList();
                return result;
            }
        }
    }
}