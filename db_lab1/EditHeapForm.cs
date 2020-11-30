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
    public partial class EditHeapForm : Form
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
        public EditHeapForm()
        {
            InitializeComponent();
            racesTableAdapter.Fill(kursWorkDataSet.Races);
            heapsTableAdapter.Fill(kursWorkDataSet.Heaps);
            edit = false;

        }

        public EditHeapForm(int id, int race_id, string type)
 : this()
        {
            racesTableAdapter.Fill(kursWorkDataSet.Races);
            heapsTableAdapter.Fill(kursWorkDataSet.Heaps);
            edit = true;
            this.id = id;
            
            comboBox_race.SelectedValue = race_id;
            comboBox_type.SelectedValue =type;
        }


        private void EditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kursWorkDataSet.Races' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'kursWorkDataSet.Heaps' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'racingDataSet.Heap' table. You can move, or remove it, as needed.

          

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                //int i = Convert.ToInt32(comboBox_rooad.SelectedValue);
                //object b = comboBox_Driver.SelectedValue;
                //int j = Convert.ToInt32(b);
                heapsTableAdapter.UpdateQuery(Convert.ToInt32(comboBox_race.SelectedValue), Convert.ToString(comboBox_type.SelectedValue), id);
            }
            else
            {
                heapsTableAdapter.InsertQuery(Convert.ToInt32(comboBox_race.SelectedValue), Convert.ToString(comboBox_type.SelectedValue));
            }
            Close();
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
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
