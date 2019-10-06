using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Time_Simulation_Part_One
{
    public abstract class Unit
    {
        protected int x;
        protected int y;
        protected int health;
        protected int maxHealth;
        protected int speed;
        protected int attack;
        protected int attackRange;
        protected int faction;
        protected string symbol;
        protected bool isAttacking;

        protected Unit(int x, int y, int health, int speed, int attack, int attackRange, int faction, string symbol, bool isAttacking)
        {
            this.x = x;
            this.y = y;
            this.health = health;
            this.maxHealth = health;
            this.speed = speed;
            this.attack = attack;
            this.attackRange = attackRange;
            this.faction = faction;
            this.symbol = symbol;
            this.isAttacking = isAttacking;
        }

        public abstract void MovePosition();
        public abstract void Combat();
        public abstract bool AttackingRange();
        public abstract int ClosestUnit();
        public abstract bool Death();
        public abstract string ToString();
        public abstract int PosX { get; set; }
        public abstract int PosY { get; set; }
        public abstract string Symbol { get;  }
    }    
}
