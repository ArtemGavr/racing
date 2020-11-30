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
    public partial class EditStarts : Form
    {
        private readonly int id;
        /// <summary>
        /// true - если запись модифицируется, false - если создаѐтся новая
        /// </summary>
        readonly bool edit;
        public EditStarts()
        {
            InitializeComponent();
            autosTableAdapter.Fill(kursWorkDataSet.Autos);
            heapsTableAdapter.Fill(kursWorkDataSet.Heaps);
            driversTableAdapter.Fill(kursWorkDataSet.Drivers);
            edit = false;
            this.id = Convert.ToInt32(startsTableAdapter1.MaxID());
            label_ID.Text = Convert.ToString(id);
        }

        public EditStarts(int id, int heap_id, int driver_id, int auto_id, int time, int pos)
 : this()
        {
            autosTableAdapter.Fill(kursWorkDataSet.Autos);
            heapsTableAdapter.Fill(kursWorkDataSet.Heaps);
            driversTableAdapter.Fill(kursWorkDataSet.Drivers);
            edit = true;
            this.id = id;
            label_ID.Text = Convert.ToString(id);

            comboBoxAuto.SelectedValue = auto_id;
            comboBox_heap.SelectedValue = heap_id;
            comboBox_driver.SelectedValue = driver_id;
            textBoxTime.Text = Convert.ToString(time);
            textBoxStartPos.Text = Convert.ToString(pos);
        }

        private void EditStarts_Load(object sender, EventArgs e)
        {
         

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (edit)
            {

                startsTableAdapter1.UpdateQuery(Convert.ToInt32(comboBox_heap.SelectedValue),
                    Convert.ToInt32(comboBox_driver.SelectedValue),
                    Convert.ToInt32(comboBoxAuto.SelectedValue),
                    Convert.ToInt32(textBoxTime.Text),
                    Convert.ToInt32(textBoxStartPos.Text),
                    id);
            }
            else
            {
                startsTableAdapter1.InsertQuery(Convert.ToInt32(comboBox_heap.SelectedValue),
                    Convert.ToInt32(comboBox_driver.SelectedValue),
                    Convert.ToInt32(comboBoxAuto.SelectedValue),
                    Convert.ToInt32(textBoxTime.Text),
                    Convert.ToInt32(textBoxStartPos.Text),
                    id);
            }
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
