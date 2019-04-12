using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace battleShip
{
    public static class UserInterface
    {
        public static string[] alphabetArray = new string[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public static string StringInput;

        public static void DisplayGameOver(string name)
        {
            Console.WriteLine("Game over, " + name + " wins!");
            Console.ReadLine();
        }

        public static void DisplayPlacementMenu(string playerName, string shipType)
        {
            Console.Write('\n');
            Console.WriteLine(playerName + ", please place your " + shipType);
            Console.WriteLine("Enter coordinates and direction (enter letter, then enter number, then 'up', 'down', 'left', or 'right')");
        }

        public static void DisplaySwitchTurn()
        {
            Console.Clear();
            Console.WriteLine("Time to switch, enter 'yes' when other player is ready");
        }

        public static void DisplayHitOrMiss(string hitMiss)
        {
            if (hitMiss == "hit")
            {
                Console.WriteLine("Hit");
            }
            else
            {
                Console.WriteLine("Miss");
            }
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

        public static void Delay()
        {
            do
            {
                DisplayAreYouReady();
                StringInput = GetUserInput();
            } while (StringInput != "yes");
        }

        public static bool InputValidation(string inputString, string validationType)
        {
            switch (validationType)
            {
                case "char":
                    if (alphabetArray.Contains(inputString.ToUpper()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "int":
                    if (int.TryParse(inputString, out int result))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }                 
                case "string":
                    return true;
                case "yesNo":
                    return true;
                default:
                    return false;
            }
        }
    }
}