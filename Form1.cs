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
        
        private void buttonLemons_Click(object sender, EventArgs e)
        {
            this.lemonadeTimer.Start();
            //this.lemonadeTimer.
            //counter++;
            //countLabel.Text = Convert.ToString(counter);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.carwashTimer.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.donutTimer.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.bankTimer.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.jakeTimer.Start();
        }

        private void managersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Manager = new Form2();
            Manager.ShowDialog();
        }

        private void upgradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Upgrades = new Form3();
            Upgrades.ShowDialog();
        }

        private void angelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 Investors = new Form4();
            Investors.ShowDialog();
        }

        private void unlocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 Unlocks = new Form5();
            Unlocks.ShowDialog();
        }


        private void lemonadeTimer_Tick(object sender, EventArgs e)
        {
        
            this.lemonadeBar.Increment(50);

            if (lemonadeBar.Value == lemonadeBar.Maximum) 
            {
                lemonadeTimer.Stop();
                lemonadeBar.Value = 0;
                counter++;
                countLabel.Text = Convert.ToString(counter);
            //else



            }
            //this.lemonadeBar.
        }

        private void carwashTimer_Tick(object sender, EventArgs e)
        {
            this.carBar.Increment(1);


            if (carBar.Value == carBar.Maximum)
            {
                carwashTimer.Stop();
                carBar.Value = 0;
                counter = counter + 3;
                countLabel.Text = Convert.ToString(counter);
                //else



            }
        }

        private void donutTimer_Tick(object sender, EventArgs e)
        {
            this.donutBar.Increment(1);


            if (donutBar.Value == donutBar.Maximum)
            {
                donutTimer.Stop();
                donutBar.Value = 0;
                counter = counter + 5;
                countLabel.Text = Convert.ToString(counter);
                //else



            }
        }

        private void bankTimer_Tick(object sender, EventArgs e)
        {
            this.bankBar.Increment(1);


            if (bankBar.Value == bankBar.Maximum)
            {
                bankTimer.Stop();
                bankBar.Value = 0;
                counter = counter + 7;
                countLabel.Text = Convert.ToString(counter);
                //else



            }
        }

        private void jakeTimer_Tick(object sender, EventArgs e)
        {
            this.jakeBar.Increment(1);


            if (jakeBar.Value == jakeBar.Maximum)
            {
                jakeTimer.Stop();
                jakeBar.Value = 0;
                counter = counter + 100;
                countLabel.Text = Convert.ToString(counter);
                //else



            }
        }









































































        private void carBar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
