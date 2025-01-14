using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormVSC4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClickDisplay.Text = "0";
            StatTotal.Text = "0";
            StatPower.Text = "1";
            UpgradeLabel.Text = "";
            MistakeLabel.Text = "";
        }

        private void DaveButton_Click(object sender, EventArgs e)
        {
            int totals = Convert.ToInt32(StatTotal.Text);
            int currents = Convert.ToInt32(ClickDisplay.Text);
            int powers = Convert.ToInt32(StatPower.Text);
            StatTotal.Text = Convert.ToString(totals + (1*powers));
            ClickDisplay.Text = Convert.ToString(currents + (1 * powers));
            UpgradeLabel.Text = "";
            MistakeLabel.Text = "";
            DaveButton.BackgroundImage = FormVSC4.Properties.Resources.finch4;
        }

        private void UpgradeButton_Click(object sender, EventArgs e)
        {
            int powers = Convert.ToInt32(StatPower.Text);
            int currents = Convert.ToInt32(ClickDisplay.Text);
            int powertester = powers * 10;
            if (currents - powertester >= 0)
            {
                StatPower.Text = Convert.ToString(powers + 1);
                ClickDisplay.Text = Convert.ToString(currents - powertester);
                UpgradeLabel.Text = $"Your power was upgraded to {powers + 1}!!!!!!";
                MistakeLabel.Text = "";
                DaveButton.BackgroundImage = FormVSC4.Properties.Resources.finch12;
            }
            else {
                UpgradeLabel.Text = "";
                MistakeLabel.Text = $"You need {powertester} clicks to upgrade!";
                DaveButton.BackgroundImage = FormVSC4.Properties.Resources.finch7;
            }
        }

        private void ClickDisplay_Click(object sender, EventArgs e)
        {

        }

    }
}
