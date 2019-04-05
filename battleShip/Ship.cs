using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleShip
{
    abstract class Ship
    {
        public int Length;
        public int[] Position;
        public bool[] Condition;
        public int Damage;

        public Ship()
        {
            Position = new int[Length];
            Condition = new bool[Length];
            Damage = 0;

            for (int i = 0; i < Length; i++)
            {
                Condition[i] = true;
            }
        }

        public virtual void MoveShip()
        {
            throw new System.NotImplementedException();
        }

        public virtual void PlaceShip()
        {
            throw new System.NotImplementedException();
        }

        public bool isSunk()
        {
            for (int i = 0; i < Length; i++)
            {
                if (Condition[i] == false)
                {
                    Damage++
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
