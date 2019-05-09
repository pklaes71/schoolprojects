using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DraftTracker
{
    public partial class draftForm : Form
    {
        //pick value constant divider
        const int DIV = 7;

        //teams array
        string[] teams = {
        "ARI",
        "ATL",
        "BAL",
        "BUF",
        "CAR",
        "CHI",
        "CIN",
        "CLE",
        "DAL",
        "DEN",
        "DET",
        "GB",
        "HOU",
        "IND",
        "JAK",
        "KC",
        "LA",
        "MIA",
        "MIN",
        "NE",
        "NO",
        "NYG",
        "NYJ",
        "OAK",
        "PHI",
        "PIT",
        "SD",
        "SEA",
        "SF",
        "TB",
        "TEN",
        "WASH"
        };

        //draft round array
        int[] round = { 1, 2, 3, 4, 5, 6, 7 };


        //round points multiplier
        int[] pickPoints = { 70, 60, 50, 40, 30, 20, 10 };

        //round points earned
        int[] roundPts = new int[7];

        //declare variables
        string team;
        string roundNumber;
        string [] output = new string[7];
        int roundNbr;
        int roundPoints;
        int pointsTotal;

        public draftForm()
        {
            InitializeComponent();

        }

        private void draftForm_Load(object sender, EventArgs e)
        {
            //import teams
            teamscomboBox.DataSource = teams;
 
        }

        private void newTrackerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            team = "";
            roundNumber = "";
            roundNbr = 0;
            roundPoints = 0;
            pointsTotal = 0;
            resultstextBox.Text = "";
            Array.Clear(output, 0, 7);
            Array.Clear(roundPts, 0, 7);
            picksbutton.Enabled = true;
            pointscheckBox.Checked = false;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pointscheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void picksbutton_Click(object sender, EventArgs e)
        {
            team = Convert.ToString(teamscomboBox.SelectedItem);
            roundNumber = (Convert.ToString(roundNbr + 1));
            int numberOfPicks = 0;
            if (roundNbr < 7)
            {
                foreach (int i in positionslistBox.SelectedIndices)
                {
                    this.output[roundNbr] += "\n" + "Round " + roundNumber + "\t" + " " + this.positionslistBox.Items[i] + "\n";
                    numberOfPicks++;
                }
                this.roundPoints = numberOfPicks * pickPoints[roundNbr];
                this.roundPts[roundNbr] = roundPoints;
                this.roundNbr += 1;
                this.picksbutton.Enabled = false;
                this.roundbutton.Enabled = true;
            }
            else
            {
                this.picksbutton.Enabled = false;
                this.roundbutton.Enabled = false;
                this.outputbutton.Focus();
            }
        }

        private void roundbutton_Click(object sender, EventArgs e)
        {
            if (roundNbr < 7)
            {
                for (int i = 0; i < round.Length; i++)
                {
                    this.pointsTotal += roundPoints;
                    this.roundbutton.Enabled = false;
                    this.picksbutton.Enabled = true;
                    this.outputbutton.Enabled = true;
                }
           }
            else
            {
                this.roundbutton.Enabled = false;
                this.outputbutton.Enabled = true;
                this.outputbutton.Focus();
            }           
            

        }

        private void outputbutton_Click(object sender, EventArgs e)
        {
            if (this.pointscheckBox.Checked)
                {
                    for (int p = 0; p < round.Length; p++)
                    {
                        this.resultstextBox.Text += ("\n" + this.output[p] + "\n" + "\n" + "\t\t" + "for " + this.roundPts[p] + " \t\n" + "\n");
                    }
                    this.resultstextBox.Text += ( "\n" + "For a total of " +  " " + Convert.ToString((pointsTotal / DIV)) + "\t\n" + "\n");
                 }
                else
                {
                    for (int p = 0; p<round.Length; p++)
                    {
                        this.resultstextBox.Text += (this.output[p] + "\n");
                    }
                }
        }

        private void teamscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            team = Convert.ToString(teamscomboBox.SelectedItem);
        }


    }
}
