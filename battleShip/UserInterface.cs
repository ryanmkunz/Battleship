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

        public static void DisplayPlacementMenu()
        {
            //pass in the ship type
            Console.WriteLine("Please place your ships");
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

        public static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Battleship!");
        }

        public static void DisplayNamePrompt(int playerNumber)
        {
            Console.WriteLine("Enter Player " + playerNumber + " name:");
        }
    }
}