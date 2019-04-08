using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace battleShip
{
    public static class UserInterface
    {
        public static string StringInput;

        public static void DisplayGameOver()
        {
            Console.WriteLine("Game over!");
        }

        public static void DisplayPlacementMenu(string playerName, string shipType)
        {
            Console.Write('\n');
            Console.WriteLine(playerName + ", please place your " + shipType);
            Console.WriteLine("Enter coordinates and direction (enter letter, then enter number, then 'up', 'down', 'left', or 'right')");
        }

        public static void DisplayHitMiss()
        {
            throw new System.NotImplementedException();
        }

        public static void DisplaySwitchTurn()
        {
            Console.Clear();
            Console.WriteLine("Time to switch, enter 'yes' when other player is ready");
        }

        public static void DisplayShipSunk()
        {
            throw new System.NotImplementedException();
        }

        public static void DisplayTargeting()
        {
            //include this in DisplayCoordinatePrompt() 
            Console.WriteLine("Enter target coordinates (enter letter, then enter number)");
        }
        public static void DisplayNamePrompt(int playerNumber)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Battleship!" + '\n' + '\n' + "Enter Player " + playerNumber + " name:");
        }

        public static void DisplayCoordinatePrompt()
        {
            Console.WriteLine("Enter coordinates (enter letter, then enter number)");
        }

        public static void DisplayAreYouReady()
        {
            Console.WriteLine("Ready to continue?");
        }

        public static string GetUserInput()
        {
            StringInput = Console.ReadLine();
            return StringInput;
        }
    }
}