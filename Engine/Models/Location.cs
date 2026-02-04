using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class Location
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }

        //adding more variables to Location class
        public int RequiredLevel { get; set; }  
        public string RequiredItem { get; set; }
        public Quest QuestAvailableHere { get; set; }

    }
}
