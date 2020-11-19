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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelName.Text = "Choose a base in the menu...";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Validate();
           // this.driverBindingSource.EndEdit();
            startsTableAdapter.Update(kursWorkDataSet);
            roadsTableAdapter.Update(kursWorkDataSet);
            racesTableAdapter.Update(kursWorkDataSet);
            heapsTableAdapter.Update(kursWorkDataSet);
            driversTableAdapter.Update(kursWorkDataSet);
            classesTableAdapter.Update(kursWorkDataSet);
            autosTableAdapter.Update(kursWorkDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kursWorkDataSet.Starts' table. You can move, or remove it, as needed.
            this.startsTableAdapter.Fill(this.kursWorkDataSet.Starts);
            // TODO: This line of code loads data into the 'kursWorkDataSet.Roads' table. You can move, or remove it, as needed.
            this.roadsTableAdapter.Fill(this.kursWorkDataSet.Roads);
            // TODO: This line of code loads data into the 'kursWorkDataSet.Races' table. You can move, or remove it, as needed.
            this.racesTableAdapter.Fill(this.kursWorkDataSet.Races);
            // TODO: This line of code loads data into the 'kursWorkDataSet.Heaps' table. You can move, or remove it, as needed.
            this.heapsTableAdapter.Fill(this.kursWorkDataSet.Heaps);
            // TODO: This line of code loads data into the 'kursWorkDataSet.Drivers' table. You can move, or remove it, as needed.
            this.driversTableAdapter.Fill(this.kursWorkDataSet.Drivers);
            // TODO: This line of code loads data into the 'kursWorkDataSet.Classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.kursWorkDataSet.Classes);
            // TODO: This line of code loads data into the 'kursWorkDataSet.Autos' table. You can move, or remove it, as needed.
            this.autosTableAdapter.Fill(this.kursWorkDataSet.Autos);
            // TODO: This line of code loads data into the 'racingDataSet.Road' table. You can move, or remove it, as needed.
          

            dataGridView1.AutoGenerateColumns = true;

        }

        private void toolStripMenuItemDrivers_Click(object sender, EventArgs e)
        {
            editFormToolStripMenuItem.Visible = false;
            bindingNavigator1.BindingSource = driversBindingSource;
            dataGridView1.DataSource = driversBindingSource;
            labelName.Text = "Drivers";
        }

        private void toolStripMenuItemRoads_Click(object sender, EventArgs e)
        {
            editFormToolStripMenuItem.Visible = false;
            bindingNavigator1.BindingSource = roadsBindingSource;
            dataGridView1.DataSource = roadsBindingSource;
            labelName.Text = "Roads";
        }

        private void toolStripMenuItemHeaps_Click(object sender, EventArgs e)
        {
            editFormToolStripMenuItem.Visible = true;
            bindingNavigator1.BindingSource = heapsBindingSource;
            dataGridView1.DataSource = heapsBindingSource;
            labelName.Text = "Heaps";
        }

        private void roadBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            editFormToolStripMenuItem.Visible = true;
            bindingNavigator1.BindingSource = roadsBindingSource;
            dataGridView1.DataSource = roadsBindingSource;
            labelName.Text = "Roads";
        }

        private void autosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editFormToolStripMenuItem.Visible = true;
            bindingNavigator1.BindingSource = autosBindingSource;
            dataGridView1.DataSource = autosBindingSource;
            labelName.Text = "Autos";
        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editFormToolStripMenuItem.Visible = true;
            bindingNavigator1.BindingSource = classesBindingSource;
            dataGridView1.DataSource = classesBindingSource;
            labelName.Text = "Classes";
        }

        private void racesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editFormToolStripMenuItem.Visible = true;
            bindingNavigator1.BindingSource = racesBindingSource;
            dataGridView1.DataSource = racesBindingSource;
            labelName.Text = "Races";
        }

        private void startsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editFormToolStripMenuItem.Visible = true;
            bindingNavigator1.BindingSource = startsBindingSource;
            dataGridView1.DataSource = startsBindingSource;
            labelName.Text = "Starts";
        }
    
    private void toolStripMenuItemChangingHeap_Click(object sender, EventArgs e)
        {
            var rs = new HeapForm();
            //var rs = new Form2();
            rs.ShowDialog();

            roadsTableAdapter.Fill(kursWorkDataSet.Roads);
            heapsTableAdapter.Fill(kursWorkDataSet.Heaps);
            driversTableAdapter.Fill(kursWorkDataSet.Drivers);


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            tableAdapterManager.UpdateAll(kursWorkDataSet);
        }

        private void qUeryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rs = new QueryEdit();
            rs.ShowDialog();

            //roadTableAdapter.Fill(racingDataSet.Road);
            //heapTableAdapter.Fill(racingDataSet.Heap);
            //driverTableAdapter.Fill(racingDataSet.Driver);
        }

        private bool edit = true;
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 1)
            {
                if (MessageBox.Show("You slected too many rows! Select one", "Change", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    return;
                }
            }
            if (!edit) return;
            var edt = new EditForm();
            edt.ShowDialog();
            heapsTableAdapter.Fill(kursWorkDataSet.Heaps);
            kursWorkDataSet.AcceptChanges();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 1)
            {
                if (MessageBox.Show("You slected too many rows! Select one", "Change", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    return;
                }
            }
            if (!edit) return;
            var st = new KursWorkDataSet.HeapsDataTable();
            heapsTableAdapter.FillByID(st,
            Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));

            object[] row = st.Rows[0].ItemArray;

            var edt = new EditForm(
            Convert.ToInt32(row[0]),
            Convert.ToInt32(row[2]),
            Convert.ToInt32(row[3]),
            Convert.ToDateTime(row[1])
            );
            edt.ShowDialog();
            heapsTableAdapter.Fill(kursWorkDataSet.Heaps);
            kursWorkDataSet.AcceptChanges();
        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 1)
            {
                if (MessageBox.Show("You slected too many rows! Select one", "Change", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    return;
                }
            }
            if (!edit) return;
            if (MessageBox.Show("Yuo want to delete row with heap ID: " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), "Change", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                heapsTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value)
                );
                heapsTableAdapter.Fill(kursWorkDataSet.Heaps);
                kursWorkDataSet.AcceptChanges();
            }
        }

        public static int age_from = 0;
        public static int age_to = 0;
        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (labelName.Text == "Drivers")
            {
                var edt = new Filtration_Drivers();
         
                edt.ShowDialog();

                try
                {
                    
                    if (age_from > age_to || age_to < 0 || age_from < 0)
                    {
                        MessageBox.Show("Incorrect values for filtering");
                        return;
                    }
                    var st = new KursWorkDataSet.DriversDataTable();
                    
                    driversTableAdapter.FilterByAge(st, age_from, age_to);
                    dataGridView1.DataSource = st;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
                return;
            }
        }
    }
}
