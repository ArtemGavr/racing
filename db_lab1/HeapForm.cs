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
    public partial class HeapForm : Form
    {
        public HeapForm()
        {
            InitializeComponent();
        }

        private void heapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.heapBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.racingDataSet);

        }

        private void driverBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driverBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.racingDataSet);

        }

        private void HeapForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'racingDataSet.Heap' table. You can move, or remove it, as needed.
            this.heapTableAdapter.Fill(this.racingDataSet.Heap);
            // TODO: This line of code loads data into the 'racingDataSet.Driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter.Fill(this.racingDataSet.Driver);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you aware of the changes being made?", "Change", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Validate();
                heapBindingSource.EndEdit();
                driverBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.racingDataSet);
                
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //heap saving
            this.Validate();
            this.heapBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.racingDataSet);
        }
    }
}
