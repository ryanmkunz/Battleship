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
            GameSetUp(player1, player2);
            OkHaveANapThenFireMissiles(player2, player1);
        }

        public void OkHaveANapThenFireMissiles(Player player, Player enemyPlayer)
        {
            player.SelectTarget(player, enemyPlayer);
            if (enemyPlayer.damage == 0)
            {
                UserInterface.DisplayGameOver(player.name);
            }
            Delay();
            SwitchTurn();
            OkHaveANapThenFireMissiles(enemyPlayer, player);                                                                
        }

        public void Delay()
        {
            do
            {
                UserInterface.DisplayAreYouReady();
                UserInterface.StringInput = UserInterface.GetUserInput();
            } while (UserInterface.StringInput != "yes");
        }
        public void SwitchTurn()
        {
            do
            {
                UserInterface.DisplaySwitchTurn();
                UserInterface.StringInput = UserInterface.GetUserInput();
            } while (UserInterface.StringInput != "yes");
        }

        public void GameSetUp(Player player, Player enemyPlayer)
        {
            UserInterface.DisplayNamePrompt(1);
            player1.name = UserInterface.GetUserInput();            
            player1.PlaceShips(player, enemyPlayer);
            Delay();
            SwitchTurn();
            UserInterface.DisplayNamePrompt(2);
            player2.name = UserInterface.GetUserInput();
            player2.PlaceShips(player, enemyPlayer);
        }
    }
}