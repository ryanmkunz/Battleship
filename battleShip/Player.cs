using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace battleShip
{
    public class Player
    {
        public Board board;
        public Ship destroyer;
        public Ship submarine;
        public Ship battship;
        public Ship carrier;

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
    }
}