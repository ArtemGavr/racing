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
			bindingNavigator1.BindingSource = teacherBindingSource;
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			teacherTableAdapter.Update(englishClubDbDataSet);
			groupTableAdapter.Update(englishClubDbDataSet);
			programTableAdapter.Update(englishClubDbDataSet);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "englishClubDbDataSet.Program". При необходимости она может быть перемещена или удалена.
			this.programTableAdapter.Fill(this.englishClubDbDataSet.Program);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "englishClubDbDataSet.Group". При необходимости она может быть перемещена или удалена.
			this.groupTableAdapter.Fill(this.englishClubDbDataSet.Group);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "englishClubDbDataSet.Teacher". При необходимости она может быть перемещена или удалена.
			this.teacherTableAdapter.Fill(this.englishClubDbDataSet.Teacher);

			dataGridView1.AutoGenerateColumns = true;

		}

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			bindingNavigator1.BindingSource = teacherBindingSource;
			dataGridView1.DataSource = teacherBindingSource;
			label1.Text = "Teachers";
		}

		private void toolStripMenuItem5_Click(object sender, EventArgs e)
		{
			bindingNavigator1.BindingSource = groupBindingSource;
			dataGridView1.DataSource = groupBindingSource;
			label1.Text = "Groups";
		}

		private void toolStripMenuItem6_Click(object sender, EventArgs e)
		{
			bindingNavigator1.BindingSource = programBindingSource;
			dataGridView1.DataSource = programBindingSource;
			label1.Text = "Programs";
		}

		private void toolStripMenuItem8_Click(object sender, EventArgs e)
		{
			var rs = new RSForm();
			rs.ShowDialog();
			teacherTableAdapter.Fill(englishClubDbDataSet.Teacher);
			groupTableAdapter.Fill(englishClubDbDataSet.Group);
			programTableAdapter.Fill(englishClubDbDataSet.Program);
		}
	}
}
