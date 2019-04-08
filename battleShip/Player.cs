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
        public Board opponentBoard;
        public destroyer destroyer;
        public submarine submarine;
        public battShip battship;
        public carrier carrier;
        public string[] targetCoordinates;
        public int damage;

        public Player()
        {
            shipnames = new List<string>() { "Destroyer", "Submarine", "Battleship", "Carrier" };
            board = new Board();
            opponentBoard = new Board();
            destroyer = new destroyer();
            submarine = new submarine();
            battship = new battShip();
            carrier = new carrier();
            targetCoordinates = new string[2];
            damage = destroyer.Length + submarine.Length + battship.Length + carrier.Length;
        }

        public void SelectTarget(Player player, Player enemyPlayer)
        {
            board.DisplayBoard();
            UserInterface.DisplayTargeting();
            targetCoordinates[0] = UserInterface.GetUserInput().ToUpper();
            targetCoordinates[1] = UserInterface.GetUserInput();
            opponentBoard.UpdateBoard(player, enemyPlayer, targetCoordinates[0], int.Parse(targetCoordinates[1]), "shoot");
            board.DisplayBoard();
        }

        public void PlaceShips(Player player, Player enemyPlayer)
        {
            board.DisplayBoard();
            destroyer.PlaceShip(name, "Destroyer");
            board.UpdateBoard(player, enemyPlayer, destroyer.Position[0].ToUpper(), int.Parse(destroyer.Position[1]), "place", destroyer.Position[2], destroyer.Length, "D");            

            board.DisplayBoard();
            submarine.PlaceShip(name, "Submarine");
            board.UpdateBoard(player, enemyPlayer, submarine.Position[0].ToUpper(), int.Parse(submarine.Position[1]), "place", submarine.Position[2], submarine.Length, "S");

            board.DisplayBoard();
            battship.PlaceShip(name, "Battleship");
            board.UpdateBoard(player, enemyPlayer, battship.Position[0].ToUpper(), int.Parse(battship.Position[1]), "place", battship.Position[2], battship.Length, "B");

            board.DisplayBoard();
            carrier.PlaceShip(name, "Carrier");
            board.UpdateBoard(player, enemyPlayer, carrier.Position[0].ToUpper(), int.Parse(carrier.Position[1]), "place", carrier.Position[2], carrier.Length, "C");
            board.DisplayBoard();
        }
    }
}