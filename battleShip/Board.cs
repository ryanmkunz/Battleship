using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleShip
{
    class Board
    {
        //testingtesting
        //variables
        public int [,] GameState = new int[20, 20];
        public int BoardSize = 20;
        

        //constructor
        public Board()
        {

        }
        //methods
        //TODO: write a board class that is called on to update the display with the new game state
        //should take in a 2d array as input 
        public void displayBoard()
        {
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
    }
}
