using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using XmlSerialization.Models;

namespace XmlSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var legendarySquad = new Team();
            var changedXmlLegendarySquad = new Team2();
            var squad = new List<Player>();

            squad.Add(new Player("Jordan", 23));
            squad.Add(new Player("Pippen", 33));
            squad.Add(new Player("Grant", 54));
            squad.Add(new Player("Cartwright", 24));
            squad.Add(new Player("Paxon", 5));

            legendarySquad.TeamName = "Chicago Bulls 1991";
            legendarySquad.Roster = squad;

            changedXmlLegendarySquad.TeamName = "Chicago Bulls Again but a bit differ";
            changedXmlLegendarySquad.Roster = squad;

            var serializer = new XmlSerializer(legendarySquad.GetType());
            var serializer2 = new XmlSerializer(changedXmlLegendarySquad.GetType());

            //            Part 1a 

            using (var writer = new StreamWriter(@"a.xml"))
            {
                serializer.Serialize(writer, legendarySquad);
            }
            //            Part 1b 
            using (var writer = new StreamWriter(@"b.xml"))
            {
                serializer2.Serialize(writer, changedXmlLegendarySquad);
            }
            //            Part 2 -> reading file with linq to xml

            Console.WriteLine("Best Duo in basketball history is ");

            var xmlDoc = XDocument.Load(@"a.xml");

            xmlDoc.Descendants("Player").Select(
                p => new Player(p.Element("Name").Value, Int32.Parse(p.Element("JerseyNumber").Value))
            ).Where(p => p.Name == "Jordan" || p.JerseyNumber == 33)
            .ToList().ForEach(p =>
            {
                Console.WriteLine("Player Name: " + p.Name);
            });
            Console.ReadLine();
        }
    }
}