using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Time_Simulation_Part_One
{
    class MeleeUnit : Unit
    {
        public MeleeUnit(int x, int y, string faction) : base(x, y, 100, 1, 10, 3, faction, 'M') { }

        public override int X
        {
            get { return x; }
            set { x = value; }
        }
        public override int Y
        {
            get { return y; }
            set { y = value; }
        }

        public override int Health
        {
            get { return health; }
            set { health = value; }
        }

        public override int MaxHealth
        {
            get { return health; }
        }

        public override string Faction
        {
            get { return faction; }
        }

        public override char Symbol
        {
            get { return symbol; }
        }

        public override bool IsDestroyed
        {
            get { return isDestroyed; }
        }

        public override bool IsInRange(Unit otherUnit)
        {
            return GetDistance(otherUnit) <= attackRange;
        }

        public override void Destroy()
        {
            isDestroyed = true;
            isAttacking = false;
            symbol = 'X';
        }

        public override Unit GetClosestUnit(Unit[] units)
        {
            double closestDistance = int.MaxValue;
            Unit closestUnit = null;

            foreach (Unit otherUnit in units)
            {
                if (otherUnit == this || otherUnit.Faction == faction || otherUnit.IsDestroyed)
                {
                    continue;
                }

                double distance = GetDistance(otherUnit);
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    closestUnit = otherUnit;
                }
            }
            return closestUnit;
        }

        public override void Attack(Unit otherUnit)
        {
            isAttacking = false;
            otherUnit.Health -= attack;
            if (otherUnit.Health <= 0)
            {
                otherUnit.Destroy();
            }
        }

        public override void Move(Unit closetUnit)
        {
            isAttacking = false;
            int xDirection = closetUnit.X - X;
            int yDirection = closetUnit.Y - Y;

            if (Math.Abs(xDirection) > Math.Abs(yDirection))
            {
                x += Math.Sign(xDirection);
            }
            else
            {
                y += Math.Sign(yDirection);
            }
        }

        public override void RunAway()
        {
            isAttacking = false;
            int direction = random.Next(0, 4);
            if (direction == 0)
            {
                x += 1;
            }
            else if (direction == 1)
            {
                x -= 1;
            }
            else if (direction == 2)
            {
                y += 1;
            }
            else
            {
                y -= 1;
            }
        }
    }
}
