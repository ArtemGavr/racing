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
    public partial class ClassType : Form
    {
        public ClassType()
        {
            InitializeComponent();
        }

        private void ClassType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kursWorkDataSet.Classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.kursWorkDataSet.Classes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.class_id = Convert.ToInt32(comboBox_Class.SelectedValue);
        }
    }
}
