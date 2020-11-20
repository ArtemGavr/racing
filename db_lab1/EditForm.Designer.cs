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
            this.comboBox_race = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.kursWorkDataSet = new Lab2BD1.KursWorkDataSet();
            this.heapsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heapsTableAdapter = new Lab2BD1.KursWorkDataSetTableAdapters.HeapsTableAdapter();
            this.racesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racesTableAdapter = new Lab2BD1.KursWorkDataSetTableAdapters.RacesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursWorkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heapsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racesBindingSource)).BeginInit();
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
            // comboBox_race
            // 
            this.comboBox_race.DataSource = this.racesBindingSource;
            this.comboBox_race.DisplayMember = "Name";
            this.comboBox_race.FormattingEnabled = true;
            this.comboBox_race.Location = new System.Drawing.Point(136, 100);
            this.comboBox_race.Name = "comboBox_race";
            this.comboBox_race.Size = new System.Drawing.Size(246, 28);
            this.comboBox_race.TabIndex = 2;
            this.comboBox_race.ValueMember = "Race_ID";
            this.comboBox_race.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_rooad_KeyPress);
            // 
            // comboBox_type
            // 
            this.comboBox_type.DataSource = this.heapsBindingSource;
            this.comboBox_type.DisplayMember = "Type";
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Location = new System.Drawing.Point(136, 167);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(246, 28);
            this.comboBox_type.TabIndex = 3;
            this.comboBox_type.ValueMember = "Type";
            this.comboBox_type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_Driver_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Race";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(78, 34);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(26, 20);
            this.label_ID.TabIndex = 8;
            this.label_ID.Text = "ID";
            // 
            // kursWorkDataSet
            // 
            this.kursWorkDataSet.DataSetName = "KursWorkDataSet";
            this.kursWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // heapsBindingSource
            // 
            this.heapsBindingSource.DataMember = "Heaps";
            this.heapsBindingSource.DataSource = this.kursWorkDataSet;
            // 
            // heapsTableAdapter
            // 
            this.heapsTableAdapter.ClearBeforeFill = true;
            // 
            // racesBindingSource
            // 
            this.racesBindingSource.DataMember = "Races";
            this.racesBindingSource.DataSource = this.kursWorkDataSet;
            // 
            // racesTableAdapter
            // 
            this.racesTableAdapter.ClearBeforeFill = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 352);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.comboBox_race);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursWorkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heapsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.ComboBox comboBox_race;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label_ID;
        private KursWorkDataSet kursWorkDataSet;
        private System.Windows.Forms.BindingSource heapsBindingSource;
        private KursWorkDataSetTableAdapters.HeapsTableAdapter heapsTableAdapter;
        private System.Windows.Forms.BindingSource racesBindingSource;
        private KursWorkDataSetTableAdapters.RacesTableAdapter racesTableAdapter;
    }
}