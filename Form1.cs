using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buter
{
    
    public partial class Form1 : Form
    {
        string cheatCodething = string.Empty; // Initialize an empty cheat code string
        int thing = 0;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("the buter dog is there, touch the buter??????? (risk of hurt bad)", "are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                DialogResult resa = MessageBox.Show("rip", "rip", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Some task…
            }
            if (res == DialogResult.No)
            { 
                DialogResult resa = MessageBox.Show("gud", "gud", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Some task…
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "touch the buter dog?");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (!timer1.Enabled) { timer1.Start(); }
            cheatCodething += e.KeyCode;
            if (e.KeyCode == Keys.Space)
            {
                var videoForm = new collbuterdogvideo();
                videoForm.ShowDialog();
            }
            if (cheatCodething.ToLower().Equals("tin"))
            {
                var imgThingy = new ppppppppppppp();
                imgThingy.ShowDialog();
                thing = 0;
                cheatCodething = string.Empty;
                timer1.Stop(); // Stop the timer when the cheat code is activated
            }
            if (cheatCodething.ToLower().Equals("windows"))
            {
                System.Diagnostics.Process.Start("https://www.microsoft.com/fr-fr/windows/?r=1");
                thing = 0;
                cheatCodething = string.Empty;
                timer1.Stop(); // Stop the timer when the cheat code is activated
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            thing++;
            if (thing >= 5)
            {
                thing = 0;
                cheatCodething = string.Empty; // Reset the cheat code string after 5 seconds
                timer1.Stop(); // Stop the timer if it reaches 5 seconds
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1 second
        }
    }
}
