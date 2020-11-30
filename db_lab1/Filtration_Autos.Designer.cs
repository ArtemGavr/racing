namespace Lab2BD1
{
    partial class Filtration_Autos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bindingSourceClass = new System.Windows.Forms.BindingSource(this.components);
            this.kursWorkDataSet = new Lab2BD1.KursWorkDataSet();
            this.classesTableAdapter = new Lab2BD1.KursWorkDataSetTableAdapters.ClassesTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonMore = new System.Windows.Forms.RadioButton();
            this.radioButtonLess = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursWorkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class auto";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bindingSourceClass;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Class_ID";
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // bindingSourceClass
            // 
            this.bindingSourceClass.DataMember = "Classes";
            this.bindingSourceClass.DataSource = this.kursWorkDataSet;
            // 
            // kursWorkDataSet
            // 
            this.kursWorkDataSet.DataSetName = "KursWorkDataSet";
            this.kursWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "engine volume";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(19, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 47);
            this.button2.TabIndex = 27;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(346, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 47);
            this.button1.TabIndex = 26;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonMore
            // 
            this.radioButtonMore.AutoSize = true;
            this.radioButtonMore.Checked = true;
            this.radioButtonMore.Location = new System.Drawing.Point(125, 74);
            this.radioButtonMore.Name = "radioButtonMore";
            this.radioButtonMore.Size = new System.Drawing.Size(106, 24);
            this.radioButtonMore.TabIndex = 29;
            this.radioButtonMore.TabStop = true;
            this.radioButtonMore.Text = "More than";
            this.radioButtonMore.UseVisualStyleBackColor = true;
            // 
            // radioButtonLess
            // 
            this.radioButtonLess.AutoSize = true;
            this.radioButtonLess.Location = new System.Drawing.Point(125, 105);
            this.radioButtonLess.Name = "radioButtonLess";
            this.radioButtonLess.Size = new System.Drawing.Size(104, 24);
            this.radioButtonLess.TabIndex = 30;
            this.radioButtonLess.TabStop = true;
            this.radioButtonLess.Text = "Less than";
            this.radioButtonLess.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(237, 82);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 31;
            // 
            // Filtration_Autos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 225);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.radioButtonLess);
            this.Controls.Add(this.radioButtonMore);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Filtration_Autos";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursWorkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bindingSourceClass;
        private KursWorkDataSet kursWorkDataSet;
        private KursWorkDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonMore;
        private System.Windows.Forms.RadioButton radioButtonLess;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}