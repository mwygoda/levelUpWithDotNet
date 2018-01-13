using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFloading.Models;

namespace EFloading.Repositories
{
    public class ExplicitlyRepository
    {
        public FootballTeam GetTeam()
        {
            using (var context = new FootballContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                var teamNoFive = context.FootballTeams
                                        .FirstOrDefault(t => t.TeamId == 5);
                context.Entry(teamNoFive).Collection(p => p.Players).Load();
                return teamNoFive;
            }
        }
    }
}
