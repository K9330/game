using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Item IRequiredToEnter { get; set; }
        public Quest QAvailableHere { get; set; }
        public Enemy EnemysExistence { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }

        public Location(int id, string name, string description,
            Item iRequiredToEnter = null, Quest qAvailableHere = null, Enemy enemysExistence = null)
        {
            ID = id;
            Name = name;
            Description = description;
            IRequiredToEnter = iRequiredToEnter;
            QAvailableHere = qAvailableHere;
            EnemysExistence = enemysExistence;
        }
    }
}