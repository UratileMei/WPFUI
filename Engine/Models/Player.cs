using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Linq;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged
    {
        private int _experiencePoints;
        private string _name;
        private int _hitPoints;
        private string _characterClass;
        private int _level;
        private int _gold;

        public string Name { 
            get { return _name; }
            set { _name = value;
                OnPropertyChanged("Name");
            }
        }
        public string CharacterClass { 
            get { return _characterClass; }
            set { OnPropertyChanged("CharacterClass"); } }

        public int HitPoints {
            get{return _hitPoints;}
            set { OnPropertyChanged("HitPoints"); }
        }
        public int ExperiencePoints {
            get { 
               return _experiencePoints; }
            set
            {
                _experiencePoints = value;
                OnPropertyChanged("ExperiencePoints");
            }
        }
        public int Level { get; set; }
        public int Gold { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
