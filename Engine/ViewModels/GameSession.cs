using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;
namespace Engine.ViewModels
{
    internal class GameSession
    {
        Player CurrentPlayer { get; set; }  
        public GameSession()
        {
            CurrentPlayer = new Player();
        }
    }
}
