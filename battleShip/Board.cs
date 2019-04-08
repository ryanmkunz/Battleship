using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleShip
{
    public class Board
    {
        public string [,] GameState;
        public string[,] EnemyGameState;
        public int BoardSize;
        public string[] alphabetArray;
        int columnNumber;
        int rowNumber;

        public Board()
        {
            BoardSize = 20;
            GameState = new string[BoardSize, BoardSize];
            alphabetArray = new string[26] {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    GameState[i, j] = "~";
                }
            }
            EnemyGameState = new string[BoardSize, BoardSize];
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    EnemyGameState[i, j] = "~";
                }                
            }
        }
        
        public void DisplayBoard()
        {
            Console.Clear();
            Console.WriteLine("Player");
            Console.Write("   ");
            for (int i = 0; i < 20; i++)
            {                
                Console.Write(" " + alphabetArray[i]);
            }
            Console.Write('\n');           
            for (int i = 0; i < BoardSize; i++)
            {
                if (i < 9)
                {
                    Console.Write("  "+(i + 1));
                }
                else
                {
                    Console.Write(" "+(i + 1));
                }               
                for (int j = 0; j < BoardSize; j++)
                {
                    Console.Write("|" + GameState[i, j]);
                }
                Console.WriteLine("|");
            }     
        }


        public void UpdateBoard(string letterCoordinate, int numberCoordinate, string updateType, string direction = "", int shipLength = 0, string shipType = "")
        {            
            columnNumber = Array.IndexOf(alphabetArray, letterCoordinate);
            rowNumber = numberCoordinate - 1;
            switch (updateType)
            {
                case "place":                    
                    switch (direction)
                    {
                        case "up":
                            for (int i = 0; i < shipLength; i++)
                            {
                                GameState[rowNumber - i, columnNumber] = shipType;
                            }
                            break;
                        case "down":
                            for (int i = 0; i < shipLength; i++)
                            {
                                GameState[rowNumber + i, columnNumber] = shipType;
                            }
                            break;
                        case "right":
                            for (int i = 0; i < shipLength; i++)
                            {
                                GameState[rowNumber, columnNumber + i] = shipType;
                            }
                            break;
                        case "left":
                            for (int i = 0; i < shipLength; i++)
                            {
                                GameState[rowNumber, columnNumber - i] = shipType;
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case "shoot":
                    if (GameState[rowNumber, columnNumber] == "D" || GameState[rowNumber, columnNumber] == "S" || GameState[rowNumber, columnNumber] == "B"
                        || GameState[rowNumber, columnNumber] == "C")
                    {
                        //change the condition of that index of that ship to false;
                    }
                    GameState[rowNumber, columnNumber] = "X";
                    break;
                default:
                    break;
            }
        }
    }
}
