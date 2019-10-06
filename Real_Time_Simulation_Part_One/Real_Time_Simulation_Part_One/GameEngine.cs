using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Time_Simulation_Part_One
{
    class GameEngine
    {
        int rounds = 0;
        public Map field;
        Random random = new Random();
        Timer timer = new Timer();
        bool isPaused = false;

        public void GameLogic()
        {
            field = new Map(20);
        }

        public void Ticker(Label lblRound)
        {
                timer.Interval = 1000 / 60;
                Rounds(lblRound);
        }
        
        public void Rounds(Label lblRound)
        {
            lblRound.Text = "ROUND: " + rounds;
            rounds++;
        }
    }
}
