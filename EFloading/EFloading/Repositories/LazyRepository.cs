using System;
using System.Collections.Generic;
using System.Linq;
using EFloading.Models;

namespace EFloading.Repositories
{
    public class LazyRepository
    {
        public List<FootballTeam> GetTeams()
        {
            using (var context = new FootballContext())
            {
                var result = context.FootballTeams
                                    .ToList();
                return result;
            }
        }
    }
}
