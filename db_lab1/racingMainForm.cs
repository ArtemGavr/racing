using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Word = Microsoft.Office.Interop.Word;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

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

            startsTableAdapter.Update(kursWorkDataSet);
            roadsTableAdapter.Update(kursWorkDataSet);
            racesTableAdapter.Update(kursWorkDataSet);
            heapsTableAdapter.Update(kursWorkDataSet);
            driversTableAdapter.Update(kursWorkDataSet);
            classesTableAdapter.Update(kursWorkDataSet);
            autosTableAdapter.Update(kursWorkDataSet);

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Validate();

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
            filterToolStripMenuItem.Visible = true;
            editHeapFormToolStripMenuItem.Visible = false;
            sortToolStripMenuItem.Visible = false;
            editStartsToolStripMenuItem.Visible = false;

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
            filterToolStripMenuItem.Visible = false;
            editHeapFormToolStripMenuItem.Visible = false;
            sortToolStripMenuItem.Visible = false;
            editStartsToolStripMenuItem.Visible = false;

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
            filterToolStripMenuItem.Visible = false;
            editHeapFormToolStripMenuItem.Visible = true;
            sortToolStripMenuItem.Visible = false;
            editStartsToolStripMenuItem.Visible = false;

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
            filterToolStripMenuItem.Visible = false;
            editHeapFormToolStripMenuItem.Visible = false;
            sortToolStripMenuItem.Visible = false;
            editStartsToolStripMenuItem.Visible = false;

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
            filterToolStripMenuItem.Visible = true;
            editHeapFormToolStripMenuItem.Visible = false;
            sortToolStripMenuItem.Visible = true;
            editStartsToolStripMenuItem.Visible = false;

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
            filterToolStripMenuItem.Visible = false;
            editHeapFormToolStripMenuItem.Visible = false;
            sortToolStripMenuItem.Visible = false;
            editStartsToolStripMenuItem.Visible = false;

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
            filterToolStripMenuItem.Visible = false;
            editHeapFormToolStripMenuItem.Visible = false;
            sortToolStripMenuItem.Visible = true;
            editStartsToolStripMenuItem.Visible = false;

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
            filterToolStripMenuItem.Visible = false;
            editHeapFormToolStripMenuItem.Visible = false;
            sortToolStripMenuItem.Visible = false;
            editStartsToolStripMenuItem.Visible = true;

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

        //Editing
        //Heaps
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
            var edt = new EditHeapForm();
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

            var edt = new EditHeapForm(
            Convert.ToInt32(row[0]),
            Convert.ToInt32(row[1]),
            Convert.ToString(row[2])
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
        // Starts
        private void addStartsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 1)
            {
                if (MessageBox.Show("You slected too many rows! Select one", "Change", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    return;
                }
            }
            if (!edit) return;
            var edt = new EditStarts();
            edt.ShowDialog();
            startsTableAdapter.Fill(kursWorkDataSet.Starts);
            kursWorkDataSet.AcceptChanges();
        }

        private void updateStartsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 1)
            {
                if (MessageBox.Show("You slected too many rows! Select one", "Change", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    return;
                }
            }
            if (!edit) return;
            var st = new KursWorkDataSet.StartsDataTable();
            startsTableAdapter.FillByID(st,
            Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));

            object[] row = st.Rows[0].ItemArray;

                int item4;

                    try
            {
               item4 =  Convert.ToInt32(row[4]);
            }
            catch
            {
                item4 = 0;
            }

            int item5;

            try
            {
                item5 = Convert.ToInt32(row[5]);
            }
            catch
            {
                item5 = 0;
            }
            var edt = new EditStarts(
            Convert.ToInt32(row[0]),
            Convert.ToInt32(row[1]),
            Convert.ToInt32(row[2]),
            Convert.ToInt32(row[3]),
           item4,
           item5
            );
            edt.ShowDialog();
            heapsTableAdapter.Fill(kursWorkDataSet.Heaps);
            kursWorkDataSet.AcceptChanges();
        }

        private void deleteStartsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 1)
            {
                if (MessageBox.Show("You slected too many rows! Select one", "Change", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    return;
                }
            }
            if (!edit) return;
            if (MessageBox.Show("Yuo want to delete row with start ID: " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), "Change", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                startsTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value)
                );
                startsTableAdapter.Fill(kursWorkDataSet.Starts);
                kursWorkDataSet.AcceptChanges();
            }
        }
    

    // Filtering
    public static int age_from = 0;
        public static int age_to = 0;

        public static int class_auto = 0;
        public static int engine_volume = 0;
        public static bool more_than = false;
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

            if (labelName.Text == "Autos")
            {
                class_auto = 0;
                engine_volume = 0;
                var edt = new Filtration_Autos();

                edt.ShowDialog();

                try
                {

                    if (engine_volume < 0)
                    {
                        MessageBox.Show("Incorrect values for filtering");
                        return;
                    }
                    var st = new KursWorkDataSet.DriversDataTable();

                    if (engine_volume == 0)
                    {
                        dataGridView1.DataSource = autosTableAdapter.GetDataByClassID(class_auto);
                    }

                    if (class_auto == 0)
                    {
                        if (more_than)
                        {
                            dataGridView1.DataSource = autosTableAdapter.GetDataByMoreThanVolume(engine_volume);
                        }
                        else
                        {
                            dataGridView1.DataSource = autosTableAdapter.GetDataByLessThanVolume(engine_volume);
                        }
                    }

                    if (class_auto != 0 && engine_volume != 0)
                    {
                        if (more_than)
                        {
                            dataGridView1.DataSource = autosTableAdapter.GetDataByMoreCLass(engine_volume, class_auto);
                        }
                        else
                        {
                            dataGridView1.DataSource = autosTableAdapter.GetDataByLessThanClass(engine_volume, class_auto);
                        }
                    }
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

        private static string passForHeapPath = System.AppDomain.CurrentDomain.BaseDirectory + @"\passForHeap_template.docx";
        private void passForHeapToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                MessageBox.Show(@"Creatting report");
                Word.Application wordApp = new Word.Application();
                wordApp.Visible = false;

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

                    Word.Table table = document.Tables[2];
                    Object oMissing = System.Reflection.Missing.Value;

                    for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                    {
                        document.Tables[2].Rows.Add(ref oMissing);

                        table.Cell(i + 1, 1).Range.Text = Convert.ToString(dataGridView2.Rows[i].Cells[1].Value) +
                            Convert.ToString(dataGridView2.Rows[i].Cells[2].Value) +
                            Convert.ToString(dataGridView2.Rows[i].Cells[3].Value);
                        table.Cell(i + 1, 2).Range.Text = Convert.ToString(dataGridView2.Rows[i].Cells[5].Value);
                        table.Cell(i + 1, 3).Range.Text = Convert.ToString(dataGridView2.Rows[i].Cells[6].Value);
                        table.Cell(i + 1, 4).Range.Text = Convert.ToString(dataGridView2.Rows[i].Cells[7].Value);
                        table.Cell(i + 1, 5).Range.Text = Convert.ToString(dataGridView2.Rows[i].Cells[8].Value);
                        table.Cell(i + 1, 6).Range.Text = Convert.ToString(dataGridView2.Rows[i].Cells[10].Value)
                            + Convert.ToString(dataGridView2.Rows[i].Cells[11].Value);
                    }

                    string passForHeapPathFile = System.AppDomain.CurrentDomain.BaseDirectory + @"\passForHeap.docx";
                    document.SaveAs(passForHeapPathFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
                wordApp.Visible = false;

                MessageBox.Show("Finished creating report");
            }
            catch (Exception ex)
            {

                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void racesResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(@"Creatting report");
                Word.Application wordApp = new Word.Application();
                wordApp.Visible = false;

                string passForHeapPath = System.AppDomain.CurrentDomain.BaseDirectory + @"\RacesResults_template.docx";
                Word.Document document = wordApp.Documents.OpenNoRepairDialog(passForHeapPath);
                document.Activate();


                try
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlDataAdapter oda = new SqlDataAdapter(
                        @"SELECT Top(3) Races.[Name]
      ,[Date_held]
	  ,MIN(Starts.Time) as riding_time,
	  drivers.[name],
	  drivers.[Lastname],
	  drivers.[Country]
     
  FROM [KursWork].[dbo].[Races]
  Inner join [KursWork].[dbo].Heaps on Heaps.[race_ID] = races.[race_ID] and [Type] = 'Final' 
  Inner join [KursWork].[dbo].Starts on heaps.[heap_ID] = Starts.[heap_ID]
  Inner join [KursWork].[dbo].Drivers on starts.[driver_ID] = drivers.[driver_ID]
	group by Races.[Name]
      ,[Date_held],
	  drivers.[name],
	  drivers.[Lastname],
	  drivers.[Country]", sqlconn);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    dataGridView2.DataSource = dt;
                    sqlconn.Close();

                    Word.Table table = document.Tables[2];
                    Object oMissing = System.Reflection.Missing.Value;

                    for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                    {
                        document.Tables[2].Rows.Add(ref oMissing);

                        table.Cell(i + 1, 1).Range.Text = Convert.ToString(dataGridView2.Rows[i].Cells[0].Value) +
                            Convert.ToString(dataGridView2.Rows[i].Cells[1].Value);
                        table.Cell(i + 1, 2).Range.Text = Convert.ToString(dataGridView2.Rows[i].Cells[2].Value);
                        table.Cell(i + 1, 3).Range.Text = Convert.ToString(dataGridView2.Rows[i].Cells[3].Value) +
                            " " + Convert.ToString(dataGridView2.Rows[i].Cells[4].Value);
                        table.Cell(i + 1, 4).Range.Text = Convert.ToString(dataGridView2.Rows[i].Cells[5].Value);

                    }

                    string passForHeapPathFile = System.AppDomain.CurrentDomain.BaseDirectory + @"\RacesResults.docx";
                    document.SaveAs(passForHeapPathFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
                wordApp.Visible = false;

                MessageBox.Show("Finished creating report");
            }
            catch (Exception ex)
            {

                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        //Search
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

        //Automation
        public struct pairr
        {
            public int start_id;
            public int heap_id;
            public int start_pos;
        }

        public struct pairr_two
        {
            public int start_id;
            public int time;
            public int heap_id;
        }

        class Mail
        {
            static Random random = new Random();
            string secretCode = Convert.ToString(random.Next(100000, 999999));
            string userMail;

            MailAddress fromMail;
            MailAddress toMail;

            public string SecretCode
            {
                get { return secretCode; }
                private set { }
            }
            public Mail() { }

            public Mail(string mail)
            {
                this.userMail = mail;
                this.fromMail = new MailAddress("autocrossua@gmail.com", "AutoCross");
                this.toMail = new MailAddress(userMail);
            }

            public void SendMail(string text)
            {
                using (MailMessage mailMessage = new MailMessage(this.fromMail, this.toMail))
                using (SmtpClient smtpClient = new SmtpClient())
                {
                    mailMessage.Subject = "Heap pass for autocross";
                    mailMessage.IsBodyHtml = false;
                    mailMessage.Body = text;

                    smtpClient.Host = "smtp.gmail.com";
                    smtpClient.Port = 587;
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(fromMail.Address, "crosspass");
                    smtpClient.Send(mailMessage);
                }

            }
        }
        private void automationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yuo want to perform automated start positions assigning ? ", "Change", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();



                SqlDataAdapter oda = new SqlDataAdapter(
                  @"SELECT TOP (1000) [Start_ID]
      ,[Time]
    ,[Heap_id]
  FROM [KursWork].[dbo].[Starts]
  WHERE [Heap_ID] in (SELECT TOP (1000) [Heap_ID]
  FROM [KursWork].[dbo].[Heaps]
  WHERE TYPE = 'Class')
  Order by [Heap_id], [Time]", sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView2.DataSource = dt;
                List<pairr_two> list_startsClass = new List<pairr_two>();
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    pairr_two bb = new pairr_two();
                    bb.time = Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value);
                    bb.start_id = Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value);
                    bb.heap_id = Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value);

                    list_startsClass.Add(bb);
                }


                try
                {
                    int start_number = 1;
                    int iteration_heap_id = list_startsClass[0].heap_id;
                    for (int i = 0; i < list_startsClass.Count; i++)
                    {
                        if (i == 0)
                        {
                            iteration_heap_id = list_startsClass[0].heap_id;
                        }

                        if (list_startsClass[i].heap_id != iteration_heap_id)
                        {
                            iteration_heap_id = list_startsClass[i].heap_id;
                            start_number = 1;
                        }

                        int class_start_id = list_startsClass[i].start_id;
                        startsTableAdapter.UpdateQueryOnClassStartIDandHeap(start_number, iteration_heap_id, class_start_id);


                        oda = new SqlDataAdapter(
                          @"SELECT Mail FROM dbo.Drivers Where Driver_ID = 
(select driver_id from dbo.Starts where start_id = " + class_start_id + ")", sqlconn);
                        DataTable dt2 = new DataTable();
                        oda.Fill(dt2);
                        // driversTableAdapter.FillByIdMAIL(dt2, class_start_id);
                        dataGridView3.DataSource = dt2;
                        string mail_address = Convert.ToString(dataGridView3.Rows[0].Cells[0].Value);
                        Mail mm = new Mail(mail_address);
                        mm.SendMail("Your start position in heap number " + iteration_heap_id + " is " + start_number);
                        start_number++;
                    }

                    kursWorkDataSet.AcceptChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(@"Error: " + ex.Message + "             Not enough heaps to generate starting sequence");
                }


                sqlconn.Close();
            }
        }

        //Sort
        private void ascNameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (labelName.Text == "Autos")
            {
                dataGridView1.DataSource = autosTableAdapter.GetDataByna();
            }

            if (labelName.Text == "Races")
            {
                dataGridView1.DataSource = racesTableAdapter.GetDataByNA();
            }

        }

        private void descNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (labelName.Text == "Autos")
            {
                dataGridView1.DataSource = autosTableAdapter.GetDataByND();
            }

            if (labelName.Text == "Races")
            {
                dataGridView1.DataSource = racesTableAdapter.GetDataByND();
            }
        }

        private void ascDateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (labelName.Text == "Autos")
            {
                dataGridView1.DataSource = autosTableAdapter.GetDataByDA();
            }

            if (labelName.Text == "Races")
            {
                dataGridView1.DataSource = racesTableAdapter.GetDataByDA();
            }
        }

        private void descDateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (labelName.Text == "Autos")
            {
                dataGridView1.DataSource = autosTableAdapter.GetDataByDD();
            }

            if (labelName.Text == "Races")
            {
                dataGridView1.DataSource = racesTableAdapter.GetDataByDD();
            }
        }

        private void ascNumberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (labelName.Text == "Autos")
            {
                dataGridView1.DataSource = autosTableAdapter.GetDataByNumA();
            }

            if (labelName.Text == "Races")
            {
                dataGridView1.DataSource = racesTableAdapter.GetDataByNumD();
            }
        }

        private void descNumberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (labelName.Text == "Autos")
            {
                dataGridView1.DataSource = autosTableAdapter.GetDataByNumA();
            }

            if (labelName.Text == "Races")
            {
                dataGridView1.DataSource = racesTableAdapter.GetDataByNumD();
            }
        }

        
    }
}
