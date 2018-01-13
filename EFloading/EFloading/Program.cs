using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFloading.Repositories;

namespace EFloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var eagerRepository = new EagerRepository();
            var lazyRepository = new LazyRepository();
            var explicityRepository = new ExplicitRepository();

            var teamsWithPlayers = eagerRepository.GetTeamsWithPlayers();
            var teams = lazyRepository.GetTeams();
            var teamNo5 = explicityRepository.GetTeam(5);
        }
    }
}
