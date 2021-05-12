using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lemonadeTimer.Start();
            //this.lemonadeTimer.
            counter++;
            countLabel.Text = Convert.ToString(counter);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter = counter + 3;
            countLabel.Text = Convert.ToString(counter);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            counter = counter + 5;
            countLabel.Text = Convert.ToString(counter);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            counter = counter + 7;
            countLabel.Text = Convert.ToString(counter);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            counter = counter + 100;
            countLabel.Text = Convert.ToString(counter);
        }

        private void managersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void upgradesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void angelsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void unlocksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lemonadeTimer_Tick(object sender, EventArgs e)
        {
            this.lemonadeBar.Increment(50);
            //this.lemonadeBar.
        }
    }
}
