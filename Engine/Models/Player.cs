using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Engine.Models
{
    public class Player : InotifyPropertyChanged
    {
        public string Name { get; set; }  
        public string CharacterClass { get; set; }
        public int HitPoints { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public int Gold { get; set; }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
    }
}
