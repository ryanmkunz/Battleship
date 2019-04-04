using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleShip
{
    public class Board
    {
        public int [,] GameState;
        public int BoardSize;
        
        public Board()
        {
            BoardSize = 20;
            GameState = new int[BoardSize, BoardSize];
        }

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
