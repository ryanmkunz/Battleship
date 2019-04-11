using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleShip
{
    public abstract class Ship
    {
        public int Length;
        public string[] Position;
        public bool[] Condition;
        public int Damage;

        public Ship()
        {
            Position = new string[3];
            Condition = new bool[Length];
            Damage = 0;

            for (int i = 0; i < Length; i++)
            {
                Condition[i] = true;
            }
        }

        public virtual void PlaceShip(string playerName, string shipType)
        {
            UserInterface.DisplayPlacementMenu(playerName, shipType);
            Position[0] = UserInterface.GetUserInput();
            Position[1] = UserInterface.GetUserInput();
            Position[2] = UserInterface.GetUserInput();
            if (!UserInterface.InputValidation(Position[0], "char") || !UserInterface.InputValidation(Position[1], "int") || !UserInterface.InputValidation(Position[2], "string"))
            {
                PlaceShip(playerName, shipType);
            }
        }

        public bool isSunk()
        {
            //maybe replace the bool array with just a counter. Do a check to see if those coordinates were targeted already before attributing damage,
            //if the ship is present then increment damage.
            for (int i = 0; i < Length; i++)
            {
                if (Condition[i] == false)
                {
                    Damage++;
                }
            }
            if (Damage == Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
