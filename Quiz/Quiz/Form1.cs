using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        int timeLeft = 60;
        bool q1Correct = false;
        bool q2Correct = false;
        bool q3Correct = false;

        public Form1()
        {
            InitializeComponent();

            groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox5.Visible = false;
        }

        private void radioButtonQ1A1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A1.Checked)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "\u00fb";
                q1Correct = false;
            }

            
        }

        private void radioButtonQ1A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A2.Checked)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "\u00fb";
                q1Correct = false;
            }

            
        }

        private void radioButtonQ1A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A3.Checked)
            {
                label3.ForeColor = Color.Green;
                label3.Text = "\u00fc";
                q1Correct = true;
            }
        }

        private void radioButtonQ2A1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2A1.Checked)
            {
                label4.ForeColor = Color.Red;
                label4.Text = "\u00fb";
                q2Correct = false;
            }
        }

        private void radioButtonQ2A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2A2.Checked)
            {
                
                label4.ForeColor = Color.Green;
                label4.Text = "\u00fc";
                q2Correct = true;
            }
        }

        private void radioButtonQ2A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2A3.Checked)
            {
                label4.ForeColor = Color.Red;
                label4.Text = "\u00fb";
                q2Correct = false;
            }
        }

        private void radioButtonQ3A1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3A1.Checked)
            {

                label5.ForeColor = Color.Green;
                label5.Text = "\u00fc";
                q3Correct = true;
            }
        }

        private void radioButtonQ3A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3A2.Checked)
            {
                label5.ForeColor = Color.Red;
                label5.Text = "\u00fb";
                q3Correct = false;
            }
        }

        private void radioButtonQ3A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3A3.Checked)
            {
                label5.ForeColor = Color.Red;
                label5.Text = "\u00fb";
                q3Correct = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(q1Correct && q2Correct && q3Correct)
            {
                timer1.Stop();
                MessageBox.Show("You got everything right");
            }else if(timeLeft > 0)
            {
                //update and display time left
                timeLeft--;
                labelTimer.Text = timeLeft + "seconds";
            }
            else
            {
                //if the time runs out
                timer1.Stop();
                labelTimer.Text = "Times up";
                MessageBox.Show("Ran out of time,", "Sorry");
            }
        }

        private void TimerButton_Click(object sender, EventArgs e)
        {
            timer1.Start();

            groupBox1.Visible = true;
            groupBox3.Visible = true;
            groupBox5.Visible = true;
            TimerButton.Hide();

        }
    }
}
