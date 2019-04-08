using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace battleShip
{
    public class Game
    {
        public Player player1;
        public Player player2;

        public Game()
        {
            player1 = new Player();
            player2 = new Player();
        }

        public void RunGame()
        {
            GameSetUp();
            OkHaveANapThenFireMissiles(player2, player1);
        }

        public void OkHaveANapThenFireMissiles(Player player, Player otherPlayer)
        {
            player.SelectTarget();
            
        }

        public void SwitchTurn()
        {
            throw new System.NotImplementedException();
        }

        public void GameSetUp()
        {
            UserInterface.DisplayNamePrompt(1);
            player1.name = UserInterface.GetUserInput();            
            player1.PlaceShips();
            do
            {
                UserInterface.DisplaySwitchTurn();
                UserInterface.StringInput = UserInterface.GetUserInput();
            } while (UserInterface.StringInput != "yes");
            UserInterface.DisplayNamePrompt(2);
            player2.name = UserInterface.GetUserInput();
            player2.PlaceShips();
            
        }
    }
}