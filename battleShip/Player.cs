using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace battleShip
{
    public class Player
    {
        public string name;
        public List<string> shipnames = new List<string>() { "Destroyer", "Submarine", "Battleship", "Carrier" };
        public Board board;
        public destroyer destroyer;
        public submarine submarine;
        public battShip battship;
        public carrier carrier;

        public Player()
        {
            board = new Board();
            destroyer = new destroyer();
            submarine = new submarine();
            battship = new battShip();
            carrier = new carrier();
        }

        public void SelectTarget()
        {
            UserInterface.DisplayTargeting();
        }

        public void PlaceShips()
        {
            foreach (var shipname in shipnames)
            {
                board.DisplayBoard();
                destroyer.PlaceShip(name, shipname);
                board.UpdateBoard();
            }
        }
    }
}