using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Random randomNumber = new Random();

        private void buttonStartTest_Click(object sender, EventArgs e)
        {
            labelQ1N1.Text = randomNumber.Next(1, 10).ToString();
            labelQ1N2.Text = randomNumber.Next(1, 10).ToString();
            labelQ2N1.Text = randomNumber.Next(1, 10).ToString();
            labelQ2N2.Text = randomNumber.Next(1, 10).ToString();
            labelQ3N1.Text = randomNumber.Next(1, 10).ToString();
            labelQ3N2.Text = randomNumber.Next(1, 10).ToString();
            labelQ4N1.Text = randomNumber.Next(1, 10).ToString();
            labelQ4N2.Text = randomNumber.Next(1, 10).ToString();
            labelQ5N1.Text = randomNumber.Next(1, 10).ToString();
            labelQ5N2.Text = randomNumber.Next(1, 10).ToString();
        }
    }
}
