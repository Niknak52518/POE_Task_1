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
        string[,] map = new string[20, 20];
        Random random = new Random();
        Unit[] units;
        int counter;

        public Map(int numOfUnits)
        {
            units = new Unit[numOfUnits];
            InitializeUnits();
        }

        private void InitializeUnits()
        {
            for (int i = 0; i < units.Length; i++)
            {
                counter = random.Next(0, 2);
                if (counter == 0)
                {
                    MeleeUnit melee = new MeleeUnit();
                    melee.PosX = random.Next(0, 20);
                    melee.PosY = random.Next(0, 20);
                    units[i] = melee;
                }
                else
                {
                    RangedUnit ranged = new RangedUnit();
                    ranged.PosX = random.Next(0, 20);
                    ranged.PosY = random.Next(0, 20);
                    units[i] = ranged;
                }
            }
        }

        public void InitializeMap()
        {
            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 20; x++)
                {
                    map[x, y] = "  .  ";
                }
            }

            for (int i = 0; i < units.Length; i++)
            {
                map[units[i].PosX, units[i].PosY] = units[i].Symbol;
            }
        }

        public void ShowBattlefield(Label lblMap)
        {
            lblMap.Text = "";
            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 20; x++)
                {
                    lblMap.Text += map[x, y];
                }
                lblMap.Text += "\n";
            }
        }

        public void DisplayInformation(RichTextBox txtInfoBox)
        {
            txtInfoBox.Text = "";
            for (int i = 0; i < 5; i++)
            {
                txtInfoBox.Text += units[i].ToString();

            }
        }
    }
}
