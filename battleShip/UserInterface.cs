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
            Console.WriteLine(playerName + ", please place your " + shipType);
            Console.WriteLine("Enter coordinates (enter letter, then enter number)");
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