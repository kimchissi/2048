/*
 * Michael Kelley & Matt Arndt
 * 27 MAR 2019
 * player class, which assigns the players name
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyFortyEight
{
    class Player
    {
        private String playerName; //attribute of the player object which hold the name
        
        private Player(String name) //constructor which sets the name of the player
        {
            this.playerName = name;
        }

        public String getName() //this returns the name of the player
        {
            return this.playerName;
        }
    }
}
