using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Time_Simulation_Part_One
{
    public partial class frmRTS : Form
    {
        Map battlefield = new Map(5);
        GameEngine ge = new GameEngine();
        bool isPaused = false;

        public frmRTS()
        {
            InitializeComponent();
            lblMap.Visible = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            battlefield.InitializeMap();
            battlefield.ShowBattlefield(lblMap);
            battlefield.DisplayInformation(txtInfoBox);
            if (isPaused == false)
            {
                ge.Ticker(lblRound);
            }
            else
            {

            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            isPaused = true;
        }
    }
}
