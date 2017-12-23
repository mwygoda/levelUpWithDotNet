using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XmlSerialization.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int JerseyNumber { get; set; }
        [XmlIgnore]
        public int Age { get; set; }

        public Player()
        {
        }

        public Player(string name, int jerseyNumber)
        {
            Name = name;
            JerseyNumber = jerseyNumber;
            Age = 99;
        }
    }
}