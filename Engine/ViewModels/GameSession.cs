using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;
namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

        //new instance of Location class
        public Location CurrentLocation { get; set; }
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "John Snow";
            CurrentPlayer.Gold = 100000;
            CurrentPlayer.CharacterClass = "Fighter";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;
            //
            CurrentLocation = new Location();
            CurrentLocation.Name = "Home";
            CurrentLocation.Description = "Your house. You really need to clean up.";
            CurrentLocation.XCoordinate = 0;
            CurrentLocation.YCoordinate = -1;
        }
    }
}
