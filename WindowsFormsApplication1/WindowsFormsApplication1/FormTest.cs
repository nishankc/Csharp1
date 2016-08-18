using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormTest : Form
    {

        string name = "";

        public FormTest()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //get name of text box
            name = textBoxName.Text;
            //work out how old person is
            DateTime today = DateTime.Now.Date;
            TimeSpan ageDays = today - dateTimePicker1.Value;

            //work out age in years
            int years = ((int)ageDays.TotalDays) / 365;

            //get date from date time picker to use in the mesaage
            int day = dateTimePicker1.Value.Day;
            //get  the month as a word
            string month = dateTimePicker1.Value.ToString("MMMM");

            //assemble message
            label3.Text = "Hello, " + name + "! You will Be" + (years + 1) + "years old on " + day + " " + month + ".";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
