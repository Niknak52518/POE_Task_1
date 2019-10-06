using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Time_Simulation_Part_One
{
    class RangedUnit : Unit
    {
        public RangedUnit() : base(0, 0, 200, 1, 10, 2, 1, "R", false)
        {

        }

        public override int PosX
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public override int PosY
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public int HP
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }

        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        public int Attack
        {
            get
            {
                return attack;
            }
            set
            {
                attack = value;
            }
        }

        public int AttackRange
        {
            get
            {
                return attackRange;
            }
            set
            {
                attackRange = value;
            }
        }

        public int Faction
        {
            get
            {
                return faction;
            }
            set
            {
                faction = value;
            }
        }

        public override string Symbol
        {
            get
            {
                return symbol;
            }
        }

        public bool IsAttacking
        {
            get
            {
                return isAttacking;
            }
            set
            {
                isAttacking = value;
            }
        }

        override public void MovePosition()
        {

        }

        override public void Combat()
        {

        }

        override public bool AttackingRange()
        {
            return false;
        }

        override public int ClosestUnit()
        {
            return 1;
        }

        override public bool  Death()
        {
            return false;
        }

        override public string ToString()
        {
            return "Ranged Unit Information: " + $"Row: {x}, Column: {y}, HP: {health}, Speed: {speed}\n";
        }
    }
}
