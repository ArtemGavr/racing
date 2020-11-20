using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Word = Microsoft.Office.Interop.Word;

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

            comboBoxDrivers.Visible = true;
            comboBoxRaces.Visible = false;
            SearchtextBox.Visible = true;
            buttonSearch.Visible = true;

            bindingNavigator1.BindingSource = driversBindingSource;
            dataGridView1.DataSource = driversBindingSource;
            labelName.Text = "Drivers";
        }
        private void toolStripMenuItemRoads_Click(object sender, EventArgs e)
        {
            editFormToolStripMenuItem.Visible = false;

            comboBoxDrivers.Visible = false;
            comboBoxRaces.Visible = false;
            SearchtextBox.Visible = false;
            buttonSearch.Visible = false;

            bindingNavigator1.BindingSource = roadsBindingSource;
            dataGridView1.DataSource = roadsBindingSource;
            labelName.Text = "Roads";
        }
        private void toolStripMenuItemHeaps_Click(object sender, EventArgs e)
        {
            editFormToolStripMenuItem.Visible = true;

            comboBoxDrivers.Visible = false;
            comboBoxRaces.Visible = false;
            SearchtextBox.Visible = false;
            buttonSearch.Visible = false;

            bindingNavigator1.BindingSource = heapsBindingSource;
            dataGridView1.DataSource = heapsBindingSource;
            labelName.Text = "Heaps";
        }
        private void roadBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            editFormToolStripMenuItem.Visible = true;

            comboBoxDrivers.Visible = false;
            comboBoxRaces.Visible = false;
            SearchtextBox.Visible = false;
            buttonSearch.Visible = false;

            bindingNavigator1.BindingSource = roadsBindingSource;
            dataGridView1.DataSource = roadsBindingSource;
            labelName.Text = "Roads";
        }
        private void autosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editFormToolStripMenuItem.Visible = true;

            comboBoxDrivers.Visible = false;
            comboBoxRaces.Visible = false;
            SearchtextBox.Visible = false;
            buttonSearch.Visible = false;

            bindingNavigator1.BindingSource = autosBindingSource;
            dataGridView1.DataSource = autosBindingSource;
            labelName.Text = "Autos";
        }
        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editFormToolStripMenuItem.Visible = true;

            comboBoxDrivers.Visible = false;
            comboBoxRaces.Visible = false;
            SearchtextBox.Visible = false;
            buttonSearch.Visible = false;

            bindingNavigator1.BindingSource = classesBindingSource;
            dataGridView1.DataSource = classesBindingSource;
            labelName.Text = "Classes";
        }
        private void racesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editFormToolStripMenuItem.Visible = true;

            comboBoxDrivers.Visible = false;
            comboBoxRaces.Visible = true;
            SearchtextBox.Visible = true;
            buttonSearch.Visible = true;

            bindingNavigator1.BindingSource = racesBindingSource;
            dataGridView1.DataSource = racesBindingSource;
            labelName.Text = "Races";
        }
        private void startsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editFormToolStripMenuItem.Visible = true;

            comboBoxDrivers.Visible = false;
            comboBoxRaces.Visible = false;
            SearchtextBox.Visible = false;
            buttonSearch.Visible = false;

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


        // statistic
        public static int class_id = 0;
        private void numberOfHeapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var edt = new ClassType();
            edt.ShowDialog();

            try
            {
                if (class_id < 0)
                {
                    MessageBox.Show("Incorrect values for class");
                    return;
                }
                MessageBox.Show("There were " +
                    heapsTableAdapter.NumberOfHeaps(class_id) +
                    " heaps", "Number of heaps with class " + class_id, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
            return;
        }
        private void averageRideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                MessageBox.Show("The average ride time is  "
                    + startsTableAdapter.AverageRideTime()
                    + " sec", "Average ride time" + class_id,
                    MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
            return;
        }
        const string ConnectionString = "Data Source=ARTEMSNOTEBOOK;Initial Catalog=KursWork;Integrated Security=True";
        private void ridesForDriversToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(
                    @"SELECT  drivers.Name, drivers.Lastname, Count(DISTINCT heaps.race_id) AS number_of_races
                    FROM dbo.Drivers
                    inner join starts on starts.driver_id = drivers.driver_id
                    inner join heaps on starts.heap_id = heaps.heap_id
                    Group by drivers.driver_id, drivers.Name, drivers.Lastname", sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
            return;

        }

        public static string month;
        private void racesNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var edt = new Month();
            edt.ShowDialog();

            try
            {
                int month_n = DateTime.ParseExact(month, "MMMM", new System.Globalization.CultureInfo("en-US")).Month;
                MessageBox.Show("There were " +
                   racesTableAdapter.RacesInMonth(month_n) +
                    " races in " + month, "Number of races in " + month, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
            return;
        }

        //Reports
        private void ReplaceWord(string stubReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubReplace, ReplaceWith: text);
        }

        private static string passForHeapPath = System.AppDomain.CurrentDomain.BaseDirectory + @"\passForHeap.docx";
        private void passForHeapToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Word.Application wordApp = new Word.Application();
            wordApp.Visible = true;

            Word.Document document = wordApp.Documents.OpenNoRepairDialog(passForHeapPath);
            document.Activate();

            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(
                    @"SELECT Drivers.[Driver_ID]
      ,Drivers.[Name]
      ,[Lastname]
      ,[MiddleName]
      ,[DOB]
      ,[Country]
      ,[Telefon]
      ,[Mail]
	  ,Starts.Start_number
	  ,Heaps.Heap_ID
	  ,Races.[Name] as Race_name 
	  ,Races.Date_held
  FROM [KursWork].[dbo].[Drivers]
  Inner join [KursWork].[dbo].Starts on Drivers.[Driver_ID] = Starts.[Driver_ID]
  Inner join [KursWork].[dbo].Heaps on Heaps.[heap_ID] = starts.[Heap_ID]
   Inner join [KursWork].[dbo].Races on Races.[Race_ID] = Heaps.[Race_ID]", sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView2.DataSource = dt;
                sqlconn.Close();

                Word.Table table = document.Tables[1];
                Object oMissing = System.Reflection.Missing.Value;
                int sum = 0;
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    document.Tables[1].Rows.Add(ref oMissing);
                    sum += Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value);
                    table.Cell(i + 2, 1).Range.Text = Convert.ToString(dataGridView2.Rows[i].Cells[0].Value);
                    table.Cell(i + 2, 2).Range.Text = Convert.ToString(dataGridView2.Rows[i].Cells[1].Value);
                }
                ReplaceWord("{sum}", Convert.ToString(sum), document);
                document.SaveAs(passForHeapPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
            wordApp.Visible = false;


        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
           
            if (labelName.Text == "Drivers")

            {
                string value = Convert.ToString(comboBoxDrivers.SelectedItem);
                if (value == "Lastname")
                {
                    try
                    {
                        string text = "%" + SearchtextBox.Text + "%";
                        dataGridView1.DataSource = driversTableAdapter.GetDataBySearchLastName(text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(@"Error: " + ex.Message);
                    }
                }
                if (value == "Country")
                {
                    try
                    {
                        string text = "%" + SearchtextBox.Text + "%";
                        dataGridView1.DataSource = driversTableAdapter.GetDataByCountry(text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(@"Error: " + ex.Message);
                    }
                }
            }

            if (labelName.Text == "Races")
            {
                string value = Convert.ToString(comboBoxRaces.SelectedItem);
                if (value == "Race_Name")
                {
                    
                    try
                    {
                        string text = "%" + SearchtextBox.Text + "%";
                        dataGridView1.DataSource = racesTableAdapter.GetDataByName(text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(@"Error: " + ex.Message);
                    }
                }
                if (value == "Class_Name")
                {
                    try
                    {
                        string text = "%" + SearchtextBox.Text + "%";
                        dataGridView1.DataSource = racesTableAdapter.GetDataByClassName(text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(@"Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
