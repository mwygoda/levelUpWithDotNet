using System;
using System.Collections.Generic;
using System.Text;

namespace XmlSerialization.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int JerseyNumber { get; set; }

        public Player ()
        { }
        public Player(string name, int jerseyNumber)
        {
            Name = name;
            JerseyNumber = jerseyNumber;
        }

    }
}
