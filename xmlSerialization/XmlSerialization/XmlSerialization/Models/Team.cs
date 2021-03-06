﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XmlSerialization.Models
{
    public class Team
    {
        public string TeamName { get; set; }
        [XmlArray]
        public List<Player> Roster { get; set; }
    }
}