using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;
namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }  
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "John Snow";
            CurrentPlayer.Gold = 100000;
            CurrentPlayer.CharacterClass = "Fighter";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;
        }
    }
}
