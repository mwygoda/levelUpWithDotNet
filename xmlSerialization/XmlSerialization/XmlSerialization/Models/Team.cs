using System;
using System.Collections.Generic;
using System.Text;

namespace XmlSerialization.Models
{
    public class Team
    {
        public string TeamName { get; set; }

        public List<Player> Roster { get; set; }
    }
}