using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2BD1
{
    public partial class Filtration_Drivers : Form
    {
        public Filtration_Drivers()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.age_from = Convert.ToInt32(filter_st1.Text);
            Form1.age_to = Convert.ToInt32(filter_fn1.Text);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Form1.age_from = Convert.ToInt32(filter_st1.Text);
            Form1.age_to = Convert.ToInt32(filter_fn1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
