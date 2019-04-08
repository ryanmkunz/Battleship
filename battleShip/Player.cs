using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace battleShip
{
    public class Player
    {
        public string name;
        public List<string> shipnames;
        public Board board;
        public destroyer destroyer;
        public submarine submarine;
        public battShip battship;
        public carrier carrier;
        public string[] targetCoordinates;

        public Player()
        {
            shipnames = new List<string>() { "Destroyer", "Submarine", "Battleship", "Carrier" };
            board = new Board();
            destroyer = new destroyer();
            submarine = new submarine();
            battship = new battShip();
            carrier = new carrier();
            targetCoordinates = new string[2];
        }

        public void SelectTarget()
        {
            UserInterface.DisplayTargeting();
            targetCoordinates[0] = Console.ReadLine().ToUpper();
            targetCoordinates[1] = Console.ReadLine();
            board.UpdateBoard(targetCoordinates[0], int.Parse(targetCoordinates[1]), "fire");
            board.DisplayBoard();
            Console.ReadLine();
        }

        public void PlaceShips()
        {
            board.DisplayBoard();
            destroyer.PlaceShip(name, "Destroyer");
            board.UpdateBoard(destroyer.Position[0].ToUpper(), int.Parse(destroyer.Position[1]), "place", destroyer.Position[2], destroyer.Length, "D");            

            board.DisplayBoard();
            submarine.PlaceShip(name, "Submarine");
            board.UpdateBoard(submarine.Position[0].ToUpper(), int.Parse(submarine.Position[1]), "place", submarine.Position[2], submarine.Length, "S");

            board.DisplayBoard();
            battship.PlaceShip(name, "Battleship");
            board.UpdateBoard(battship.Position[0].ToUpper(), int.Parse(battship.Position[1]), "place", battship.Position[2], battship.Length, "B");

            board.DisplayBoard();
            carrier.PlaceShip(name, "Carrier");
            board.UpdateBoard(carrier.Position[0].ToUpper(), int.Parse(carrier.Position[1]), "place", carrier.Position[2], carrier.Length, "C");
            board.DisplayBoard();
        }
    }
}