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
    public partial class Filtration_Autos : Form
    {
        public Filtration_Autos()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kursWorkDataSet.Classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.kursWorkDataSet.Classes);
            comboBox1.SelectedValue = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.engine_volume = Convert.ToInt32(numericUpDown1.Value);
            Form1.class_auto = Convert.ToInt32(comboBox1.SelectedValue);
            if (radioButtonMore.Checked) { 
                Form1.more_than = true; }
            else { Form1.more_than = false; }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
