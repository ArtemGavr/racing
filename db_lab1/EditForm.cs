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
    public partial class EditForm : Form
    {
        /// <summary>
        /// Id студента
        /// </summary>
        private readonly int id;
        /// <summary>
        /// true - если запись модифицируется, false - если создаѐтся новая
        /// </summary>
        readonly bool edit;
        /// <summary>
        /// конструктор формы, для создания новой записи
        /// </summary>
      
            //!!!
        public EditForm()
        {
            InitializeComponent();
            roadTableAdapter.Fill(racingDataSet.Road);
            driverTableAdapter.Fill(racingDataSet.Driver);
            edit = false;

        }

        public EditForm(int id, int driver_id, int road_id, DateTime startDate)
 : this()
        {
            roadTableAdapter.Fill(racingDataSet.Road);
            driverTableAdapter.Fill(racingDataSet.Driver);
            edit = true;
            this.id = id;
            dateTimePicker1.Value = startDate;
            comboBox_rooad.SelectedValue = road_id;
            comboBox_Driver.SelectedValue =driver_id;
        }


        private void EditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'racingDataSet.Heap' table. You can move, or remove it, as needed.
            this.heapTableAdapter.Fill(this.racingDataSet.Heap);
          

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                //int i = Convert.ToInt32(comboBox_rooad.SelectedValue);
                //object b = comboBox_Driver.SelectedValue;
                //int j = Convert.ToInt32(b);
                heapTableAdapter.UpdateQueryHeap(dateTimePicker1.Value, Convert.ToInt32(comboBox_Driver.SelectedValue), Convert.ToInt32(comboBox_rooad.SelectedValue), id);
            }
            else
            {
                heapTableAdapter.Insert(dateTimePicker1.Value, Convert.ToInt32(comboBox_Driver.SelectedValue), Convert.ToInt32(comboBox_rooad.SelectedValue));
            }
            Close();
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox_rooad_ValueMemberChanged(object sender, EventArgs e)
        {
        }

        private void comboBox_rooad_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void comboBox_rooad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox_Driver_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
