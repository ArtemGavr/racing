namespace Lab2BD1
{
    partial class EditForm
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
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.comboBox_rooad = new System.Windows.Forms.ComboBox();
            this.roadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.racingDataSet = new Lab2BD1.RacingDataSet();
            this.comboBox_Driver = new System.Windows.Forms.ComboBox();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roadTableAdapter = new Lab2BD1.RacingDataSetTableAdapters.RoadTableAdapter();
            this.driverTableAdapter = new Lab2BD1.RacingDataSetTableAdapters.DriverTableAdapter();
            this.bindingSourceHeap = new System.Windows.Forms.BindingSource(this.components);
            this.heapTableAdapter = new Lab2BD1.RacingDataSetTableAdapters.HeapTableAdapter();
            this.label_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHeap)).BeginInit();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(24, 240);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(80, 56);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(302, 240);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(80, 56);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // comboBox_rooad
            // 
            this.comboBox_rooad.DataSource = this.roadBindingSource;
            this.comboBox_rooad.DisplayMember = "Name";
            this.comboBox_rooad.FormattingEnabled = true;
            this.comboBox_rooad.Location = new System.Drawing.Point(136, 100);
            this.comboBox_rooad.Name = "comboBox_rooad";
            this.comboBox_rooad.Size = new System.Drawing.Size(246, 28);
            this.comboBox_rooad.TabIndex = 2;
            this.comboBox_rooad.ValueMember = "Road_ID";
            this.comboBox_rooad.ValueMemberChanged += new System.EventHandler(this.comboBox_rooad_ValueMemberChanged);
            this.comboBox_rooad.SelectedValueChanged += new System.EventHandler(this.comboBox_rooad_SelectedValueChanged);
            this.comboBox_rooad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_rooad_KeyPress);
            // 
            // roadBindingSource
            // 
            this.roadBindingSource.DataMember = "Road";
            this.roadBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.racingDataSet;
            this.bindingSource1.Position = 0;
            // 
            // racingDataSet
            // 
            this.racingDataSet.DataSetName = "RacingDataSet";
            this.racingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox_Driver
            // 
            this.comboBox_Driver.DataSource = this.driverBindingSource;
            this.comboBox_Driver.DisplayMember = "Lastname";
            this.comboBox_Driver.FormattingEnabled = true;
            this.comboBox_Driver.Location = new System.Drawing.Point(136, 167);
            this.comboBox_Driver.Name = "comboBox_Driver";
            this.comboBox_Driver.Size = new System.Drawing.Size(246, 28);
            this.comboBox_Driver.TabIndex = 3;
            this.comboBox_Driver.ValueMember = "Driver_ID";
            this.comboBox_Driver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_Driver_KeyPress);
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "Driver";
            this.driverBindingSource.DataSource = this.bindingSource1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Heap date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Driver";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Road ";
            // 
            // roadTableAdapter
            // 
            this.roadTableAdapter.ClearBeforeFill = true;
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSourceHeap
            // 
            this.bindingSourceHeap.DataMember = "Heap";
            this.bindingSourceHeap.DataSource = this.racingDataSet;
            // 
            // heapTableAdapter
            // 
            this.heapTableAdapter.ClearBeforeFill = true;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(273, 10);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(26, 20);
            this.label_ID.TabIndex = 8;
            this.label_ID.Text = "ID";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 352);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox_Driver);
            this.Controls.Add(this.comboBox_rooad);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHeap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.ComboBox comboBox_rooad;
        private System.Windows.Forms.ComboBox comboBox_Driver;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private RacingDataSet racingDataSet;
        private System.Windows.Forms.BindingSource roadBindingSource;
        private RacingDataSetTableAdapters.RoadTableAdapter roadTableAdapter;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private RacingDataSetTableAdapters.DriverTableAdapter driverTableAdapter;
        private System.Windows.Forms.BindingSource bindingSourceHeap;
        private RacingDataSetTableAdapters.HeapTableAdapter heapTableAdapter;
        private System.Windows.Forms.Label label_ID;
    }
}