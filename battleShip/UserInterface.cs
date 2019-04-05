using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace battleShip
{
    public static class UserInterface
    {
        public static void DisplayGameOver()
        {
            throw new System.NotImplementedException();
        }

        public static void DisplayPlacementMenu(string playerName, string shipType)
        {
            //pass in the ship type
            Console.WriteLine(playerName + ", please place your " + shipType);
            Console.WriteLine("Enter coordinates");
        }

        public static void DisplayHitMiss()
        {
            throw new System.NotImplementedException();
        }

        public static void DisplaySwitchTurn()
        {
            throw new System.NotImplementedException();
        }

        public static void DisplayShipSunk()
        {
            throw new System.NotImplementedException();
        }

        public static void DisplayTargeting()
        {
            throw new System.NotImplementedException();
        }
        public static void DisplayNamePrompt(int playerNumber)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Battleship!" + '\n' + "Enter Player " + playerNumber + " name:");
        }
    }
}