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
                    GameState[i, j] = " ";
                }
            }
        }
        
        public void DisplayBoard()
        {
            Console.Clear();
            Console.WriteLine("    A"+" B"+" C" + " D" + " E" + " F" + " G" + " H" + " I" + " J" + " K" + " L" + " M" + " N" + " O" + " P" + " Q" + " R" + " S" + " T");
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
            Console.ReadLine();
        }


        public void UpdateBoard(string letterCoordinate, int numberCoordinate, string shipType, string updateType)
        {            
            columnNumber = Array.IndexOf(alphabetArray, letterCoordinate);
            rowNumber = numberCoordinate - 1;
            switch (updateType)
            {
                case "place":
                    GameState[columnNumber, rowNumber] = shipType;
                    break;
                default:
                    break;
            }
        }
    }
}
