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
                Environment.Exit(0);
            }
            //UserInterface.Delay();
            SwitchTurn();
            OkHaveANapThenFireMissiles(enemyPlayer, player);                                                                
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
            player1.GetPlayerName(1, player1);
            player1.PlaceShips(player, enemyPlayer);
            //UserInterface.Delay();
            SwitchTurn();
            enemyPlayer.GetPlayerName(2, player2);
            player2.PlaceShips(player, enemyPlayer);
        }
    }
}