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
            board.DisplayBoard();
            destroyer.PlaceShip(name, "Destroyer");
            board.UpdateBoard(destroyer.Position[0], int.Parse(destroyer.Position[1]), "D", "place");

            board.DisplayBoard();
            submarine.PlaceShip(name, "Submarine");
            board.UpdateBoard(submarine.Position[0], int.Parse(submarine.Position[1]), "S", "place");

            board.DisplayBoard();
            battship.PlaceShip(name, "Battleship");
            board.UpdateBoard(battship.Position[0], int.Parse(battship.Position[1]), "B", "place");

            board.DisplayBoard();
            carrier.PlaceShip(name, "Carrier");
            board.UpdateBoard(carrier.Position[0], int.Parse(carrier.Position[1]), "C", "place");
        }
    }
}