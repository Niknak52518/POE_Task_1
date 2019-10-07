using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Time_Simulation_Part_One
{
    public abstract class Unit
    {
        protected int x, y, health, maxHealth, speed, attack, attackRange;
        protected string faction;
        protected char symbol;
        protected bool isAttacking = false;
        protected bool isDestroyed = false;
        public static Random random = new Random();

        public Unit(int x, int y, int health, int speed, int attack, int attackRange, string faction, char symbol)
        {
            this.x = x;
            this.y = y;
            this.health = health;
            maxHealth = health;
            this.speed = speed;
            this.attack = attack;
            this.attackRange = attackRange;
            this.faction = faction;
            this.symbol = symbol;
        }

        public abstract int X { get; set; }
        public abstract int Y { get; set; }
        public abstract int Health { get; set; }
        public abstract int MaxHealth { get; set; }
        public abstract string Faction { get; set; }
        public abstract char Symbol { get; }
        public abstract bool IsDestroyed { get; }
        public abstract void Move(Unit closetUnit);
        public abstract void Attack(Unit otherUnit);
        public abstract void RunAway();
        public abstract bool IsInRange(Unit otherUnit);
        public abstract Unit GetClosestUnit(Unit[] units);
        public abstract void Destroy();

        protected double GetDistance(Unit otherUnit)
        {
            double xDistance = otherUnit.X - X;
            double yDistance = otherUnit.Y - Y;
            return Math.Sqrt(xDistance * xDistance + yDistance * yDistance);
        }

        public override string ToString()
        {
            return "Position: " + x + ", " + y + "\n" +
                "Health: " + health + " / " + maxHealth + "\n" +
                "Faction: " + faction + " (" + symbol + ") \n";
        }
    }    
}
