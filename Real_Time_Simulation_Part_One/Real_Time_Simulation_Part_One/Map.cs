using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Time_Simulation_Part_One
{
    class Map
    {
        int mapSize = 20;
        Random random = new Random();
        int numUnits;
        Unit[] units;
        string[,] map;
        string[] factions = { "A-Team", "B-Team" };

        public Map(int numUnits)
        {
            this.numUnits = numUnits;
            Reset();
        }

        public Unit[] Units
        {
            get { return units; }
        }

        public int Size
        {
            get { return mapSize; }
        }

        public string GetMapDisplay()
        {
            string mapString = "";
            for (int y = 0; y < mapSize; y++)
            {
                for (int x = 0; x < mapSize; x++)
                {
                    mapString += map[x, y];
                }
                mapString += "\n";
            }
            return mapString;
        }

        public void Reset()
        {
            map = new string[mapSize, mapSize];
            units = new Unit[numUnits];
            InitializeUnits();
            UpdateMap();
        }

        public void UpdateMap()
        {
            for (int y = 0; y < mapSize; y++)
            {
                for (int x = 0; x < mapSize; x++)
                {
                    map[x, y] = " . ";
                }
            }
            foreach(Unit unit in units)
            {
                map[unit.X, unit.Y] = unit.Faction[0] + " / " + unit.Symbol; 
            }
        }

        private void InitializeUnits()
        {
            for (int i = 0; i < units.Length; i++)
            {
                int x = random.Next(0, mapSize);
                int y = random.Next(0, mapSize);
                int factionIndex = random.Next(0, 2);
                int unitType = random.Next(0, 2);

                while (map[x,y] != null)
                {
                    x = random.Next(0, mapSize);
                    y = random.Next(0, mapSize);
                }
                if (unitType == 0)
                {
                    units[i] = new MeleeUnit(x, y, factions[factionIndex]);
                }
                else
                {
                    units[i] = new RangedUnit(x, y, factions[factionIndex]);
                }
                map[x, y] = units[i].Faction[0] + "/" + units[i].Symbol;
            }
        }
    }
}
