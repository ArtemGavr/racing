namespace Lab2BD1
{
    partial class EditStarts
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
            this.label_ID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Driver = new System.Windows.Forms.Label();
            this.comboBox_driver = new System.Windows.Forms.ComboBox();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kursWorkDataSet = new Lab2BD1.KursWorkDataSet();
            this.comboBox_heap = new System.Windows.Forms.ComboBox();
            this.heapsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAuto = new System.Windows.Forms.ComboBox();
            this.autosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Time = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxStartPos = new System.Windows.Forms.TextBox();
            this.heapsTableAdapter = new Lab2BD1.KursWorkDataSetTableAdapters.HeapsTableAdapter();
            this.driversTableAdapter = new Lab2BD1.KursWorkDataSetTableAdapters.DriversTableAdapter();
            this.autosTableAdapter = new Lab2BD1.KursWorkDataSetTableAdapters.AutosTableAdapter();
            this.startsTableAdapter1 = new Lab2BD1.KursWorkDataSetTableAdapters.StartsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursWorkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heapsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(51, 19);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(26, 20);
            this.label_ID.TabIndex = 15;
            this.label_ID.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Heap";
            // 
            // Driver
            // 
            this.Driver.AutoSize = true;
            this.Driver.Location = new System.Drawing.Point(44, 122);
            this.Driver.Name = "Driver";
            this.Driver.Size = new System.Drawing.Size(50, 20);
            this.Driver.TabIndex = 13;
            this.Driver.Text = "Driver";
            // 
            // comboBox_driver
            // 
            this.comboBox_driver.DataSource = this.driversBindingSource;
            this.comboBox_driver.DisplayMember = "Lastname";
            this.comboBox_driver.FormattingEnabled = true;
            this.comboBox_driver.Location = new System.Drawing.Point(126, 119);
            this.comboBox_driver.Name = "comboBox_driver";
            this.comboBox_driver.Size = new System.Drawing.Size(246, 28);
            this.comboBox_driver.TabIndex = 12;
            this.comboBox_driver.ValueMember = "Driver_ID";
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataMember = "Drivers";
            this.driversBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.kursWorkDataSet;
            this.bindingSource1.Position = 0;
            // 
            // kursWorkDataSet
            // 
            this.kursWorkDataSet.DataSetName = "KursWorkDataSet";
            this.kursWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox_heap
            // 
            this.comboBox_heap.DataSource = this.heapsBindingSource;
            this.comboBox_heap.DisplayMember = "Heap_ID";
            this.comboBox_heap.FormattingEnabled = true;
            this.comboBox_heap.Location = new System.Drawing.Point(126, 69);
            this.comboBox_heap.Name = "comboBox_heap";
            this.comboBox_heap.Size = new System.Drawing.Size(246, 28);
            this.comboBox_heap.TabIndex = 11;
            this.comboBox_heap.ValueMember = "Heap_ID";
            // 
            // heapsBindingSource
            // 
            this.heapsBindingSource.DataMember = "Heaps";
            this.heapsBindingSource.DataSource = this.bindingSource1;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(21, 335);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(80, 56);
            this.button_Cancel.TabIndex = 10;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(292, 335);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(80, 56);
            this.button_OK.TabIndex = 9;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Auto";
            // 
            // comboBoxAuto
            // 
            this.comboBoxAuto.DataSource = this.autosBindingSource;
            this.comboBoxAuto.DisplayMember = "Reg_number";
            this.comboBoxAuto.FormattingEnabled = true;
            this.comboBoxAuto.Location = new System.Drawing.Point(126, 180);
            this.comboBoxAuto.Name = "comboBoxAuto";
            this.comboBoxAuto.Size = new System.Drawing.Size(246, 28);
            this.comboBoxAuto.TabIndex = 16;
            this.comboBoxAuto.ValueMember = "Auto_ID";
            // 
            // autosBindingSource
            // 
            this.autosBindingSource.DataMember = "Autos";
            this.autosBindingSource.DataSource = this.bindingSource1;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(51, 236);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(43, 20);
            this.Time.TabIndex = 18;
            this.Time.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Start position";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(126, 230);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(246, 26);
            this.textBoxTime.TabIndex = 20;
            // 
            // textBoxStartPos
            // 
            this.textBoxStartPos.Location = new System.Drawing.Point(126, 283);
            this.textBoxStartPos.Name = "textBoxStartPos";
            this.textBoxStartPos.Size = new System.Drawing.Size(246, 26);
            this.textBoxStartPos.TabIndex = 21;
            // 
            // heapsTableAdapter
            // 
            this.heapsTableAdapter.ClearBeforeFill = true;
            // 
            // driversTableAdapter
            // 
            this.driversTableAdapter.ClearBeforeFill = true;
            // 
            // autosTableAdapter
            // 
            this.autosTableAdapter.ClearBeforeFill = true;
            // 
            // startsTableAdapter1
            // 
            this.startsTableAdapter1.ClearBeforeFill = true;
            // 
            // EditStarts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 449);
            this.Controls.Add(this.textBoxStartPos);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAuto);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Driver);
            this.Controls.Add(this.comboBox_driver);
            this.Controls.Add(this.comboBox_heap);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Name = "EditStarts";
            this.Text = "EditStarts";
            this.Load += new System.EventHandler(this.EditStarts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursWorkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heapsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Driver;
        private System.Windows.Forms.ComboBox comboBox_driver;
        private System.Windows.Forms.ComboBox comboBox_heap;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAuto;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxStartPos;
        private System.Windows.Forms.BindingSource bindingSource1;
        private KursWorkDataSet kursWorkDataSet;
        private System.Windows.Forms.BindingSource heapsBindingSource;
        private KursWorkDataSetTableAdapters.HeapsTableAdapter heapsTableAdapter;
        private System.Windows.Forms.BindingSource driversBindingSource;
        private KursWorkDataSetTableAdapters.DriversTableAdapter driversTableAdapter;
        private System.Windows.Forms.BindingSource autosBindingSource;
        private KursWorkDataSetTableAdapters.AutosTableAdapter autosTableAdapter;
        private KursWorkDataSetTableAdapters.StartsTableAdapter startsTableAdapter1;
    }
}