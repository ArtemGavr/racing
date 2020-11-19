using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab2BD1
{
    public partial class QueryEdit : Form
    {
        const string ConnectionString = @"Data Source=ARTEMSNOTEBOOK;Initial Catalog=KursWork;Integrated Security=True";
        public QueryEdit()
        {
            InitializeComponent();
        }

        private void DOSQL_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(richTextBox1.Text, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Select";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
