namespace Lab2BD1
{
    partial class HeapForm
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
            System.Windows.Forms.Label driver_IDLabel;
            System.Windows.Forms.Label lastnameLabel;
            System.Windows.Forms.Label middle_nameLabel;
            System.Windows.Forms.Label classLabel;
            System.Windows.Forms.Label telephoneNumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeapForm));
            this.driverBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racingDataSet = new Lab2BD1.RacingDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.driverBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.driver_IDTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.middle_nameTextBox = new System.Windows.Forms.TextBox();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.telephoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.heapDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.driverTableAdapter = new Lab2BD1.RacingDataSetTableAdapters.DriverTableAdapter();
            this.tableAdapterManager = new Lab2BD1.RacingDataSetTableAdapters.TableAdapterManager();
            this.heapTableAdapter = new Lab2BD1.RacingDataSetTableAdapters.HeapTableAdapter();
            driver_IDLabel = new System.Windows.Forms.Label();
            lastnameLabel = new System.Windows.Forms.Label();
            middle_nameLabel = new System.Windows.Forms.Label();
            classLabel = new System.Windows.Forms.Label();
            telephoneNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingNavigator)).BeginInit();
            this.driverBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heapDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // driver_IDLabel
            // 
            driver_IDLabel.AutoSize = true;
            driver_IDLabel.Location = new System.Drawing.Point(30, 53);
            driver_IDLabel.Name = "driver_IDLabel";
            driver_IDLabel.Size = new System.Drawing.Size(75, 20);
            driver_IDLabel.TabIndex = 1;
            driver_IDLabel.Text = "Driver ID:";
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new System.Drawing.Point(30, 85);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new System.Drawing.Size(84, 20);
            lastnameLabel.TabIndex = 3;
            lastnameLabel.Text = "Lastname:";
            // 
            // middle_nameLabel
            // 
            middle_nameLabel.AutoSize = true;
            middle_nameLabel.Location = new System.Drawing.Point(30, 117);
            middle_nameLabel.Name = "middle_nameLabel";
            middle_nameLabel.Size = new System.Drawing.Size(103, 20);
            middle_nameLabel.TabIndex = 5;
            middle_nameLabel.Text = "Middle name:";
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Location = new System.Drawing.Point(30, 149);
            classLabel.Name = "classLabel";
            classLabel.Size = new System.Drawing.Size(52, 20);
            classLabel.TabIndex = 7;
            classLabel.Text = "Class:";
            // 
            // telephoneNumberLabel
            // 
            telephoneNumberLabel.AutoSize = true;
            telephoneNumberLabel.Location = new System.Drawing.Point(30, 181);
            telephoneNumberLabel.Name = "telephoneNumberLabel";
            telephoneNumberLabel.Size = new System.Drawing.Size(148, 20);
            telephoneNumberLabel.TabIndex = 9;
            telephoneNumberLabel.Text = "Telephone Number:";
            // 
            // driverBindingNavigator
            // 
            this.driverBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.driverBindingNavigator.BindingSource = this.driverBindingSource;
            this.driverBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.driverBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.driverBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.driverBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.driverBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.driverBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.driverBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.driverBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.driverBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.driverBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.driverBindingNavigator.Name = "driverBindingNavigator";
            this.driverBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.driverBindingNavigator.Size = new System.Drawing.Size(800, 33);
            this.driverBindingNavigator.TabIndex = 0;
            this.driverBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "Driver";
            this.driverBindingSource.DataSource = this.racingDataSet;
            // 
            // racingDataSet
            // 
            this.racingDataSet.DataSetName = "RacingDataSet";
            this.racingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // driverBindingNavigatorSaveItem
            // 
            this.driverBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.driverBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("driverBindingNavigatorSaveItem.Image")));
            this.driverBindingNavigatorSaveItem.Name = "driverBindingNavigatorSaveItem";
            this.driverBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.driverBindingNavigatorSaveItem.Text = "Save Data";
            this.driverBindingNavigatorSaveItem.Click += new System.EventHandler(this.driverBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // driver_IDTextBox
            // 
            this.driver_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "Driver_ID", true));
            this.driver_IDTextBox.Location = new System.Drawing.Point(184, 50);
            this.driver_IDTextBox.Name = "driver_IDTextBox";
            this.driver_IDTextBox.ReadOnly = true;
            this.driver_IDTextBox.Size = new System.Drawing.Size(100, 26);
            this.driver_IDTextBox.TabIndex = 2;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "Lastname", true));
            this.lastnameTextBox.Location = new System.Drawing.Point(184, 82);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(100, 26);
            this.lastnameTextBox.TabIndex = 4;
            // 
            // middle_nameTextBox
            // 
            this.middle_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "Middle name", true));
            this.middle_nameTextBox.Location = new System.Drawing.Point(184, 114);
            this.middle_nameTextBox.Name = "middle_nameTextBox";
            this.middle_nameTextBox.Size = new System.Drawing.Size(100, 26);
            this.middle_nameTextBox.TabIndex = 6;
            // 
            // classTextBox
            // 
            this.classTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "Class", true));
            this.classTextBox.Location = new System.Drawing.Point(184, 146);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(100, 26);
            this.classTextBox.TabIndex = 8;
            // 
            // telephoneNumberTextBox
            // 
            this.telephoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "TelephoneNumber", true));
            this.telephoneNumberTextBox.Location = new System.Drawing.Point(184, 178);
            this.telephoneNumberTextBox.Name = "telephoneNumberTextBox";
            this.telephoneNumberTextBox.Size = new System.Drawing.Size(100, 26);
            this.telephoneNumberTextBox.TabIndex = 10;
            // 
            // heapDataGridView
            // 
            this.heapDataGridView.AutoGenerateColumns = false;
            this.heapDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.heapDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.heapDataGridView.DataSource = this.heapBindingSource;
            this.heapDataGridView.Location = new System.Drawing.Point(34, 229);
            this.heapDataGridView.Name = "heapDataGridView";
            this.heapDataGridView.RowHeadersWidth = 62;
            this.heapDataGridView.RowTemplate.Height = 28;
            this.heapDataGridView.Size = new System.Drawing.Size(674, 220);
            this.heapDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "StartDate";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Driver_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Driver_ID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Road_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Road_ID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // heapBindingSource
            // 
            this.heapBindingSource.DataMember = "FK__Heap__Driver_ID__286302EC";
            this.heapBindingSource.DataSource = this.driverBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 85);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 56);
            this.button1.TabIndex = 12;
            this.button1.Text = "Accept ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DriverTableAdapter = this.driverTableAdapter;
            this.tableAdapterManager.HeapTableAdapter = this.heapTableAdapter;
            this.tableAdapterManager.RoadTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Lab2BD1.RacingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // heapTableAdapter
            // 
            this.heapTableAdapter.ClearBeforeFill = true;
            // 
            // HeapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.heapDataGridView);
            this.Controls.Add(driver_IDLabel);
            this.Controls.Add(this.driver_IDTextBox);
            this.Controls.Add(lastnameLabel);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(middle_nameLabel);
            this.Controls.Add(this.middle_nameTextBox);
            this.Controls.Add(classLabel);
            this.Controls.Add(this.classTextBox);
            this.Controls.Add(telephoneNumberLabel);
            this.Controls.Add(this.telephoneNumberTextBox);
            this.Controls.Add(this.driverBindingNavigator);
            this.Name = "HeapForm";
            this.Text = "HeapForm";
            this.Load += new System.EventHandler(this.HeapForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingNavigator)).EndInit();
            this.driverBindingNavigator.ResumeLayout(false);
            this.driverBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heapDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RacingDataSet racingDataSet;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private RacingDataSetTableAdapters.DriverTableAdapter driverTableAdapter;
        private RacingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator driverBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton driverBindingNavigatorSaveItem;
        private RacingDataSetTableAdapters.HeapTableAdapter heapTableAdapter;
        private System.Windows.Forms.TextBox driver_IDTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox middle_nameTextBox;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.TextBox telephoneNumberTextBox;
        private System.Windows.Forms.BindingSource heapBindingSource;
        private System.Windows.Forms.DataGridView heapDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}