using System.Collections.Generic;
using System.Xml.Serialization;

namespace XmlSerialization.Models
{
    [XmlRoot("CHANGEDTEAM")]
    public class Team2
    {
        [XmlElement("DIFFRENTTEAMNAME")]
        public string TeamName { get; set; }
        [XmlElement("Basketballer")]
        public List<Player> Roster { get; set; }
    }
}