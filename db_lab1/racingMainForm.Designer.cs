namespace Lab2BD1
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRoads = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHeaps = new System.Windows.Forms.ToolStripMenuItem();
            this.autosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.racesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemChangingHeap = new System.Windows.Forms.ToolStripMenuItem();
            this.qUeryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editHeapFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfHeapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageRideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ridesForDriversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.racesNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passForHeapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.racesResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascDateToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.descDateToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.numberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascNumberToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.descNumberToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelName = new System.Windows.Forms.Label();
            this.autosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursWorkDataSet = new Lab2BD1.KursWorkDataSet();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heapsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.startsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.comboBoxDrivers = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxRaces = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.autosTableAdapter = new Lab2BD1.KursWorkDataSetTableAdapters.AutosTableAdapter();
            this.classesTableAdapter = new Lab2BD1.KursWorkDataSetTableAdapters.ClassesTableAdapter();
            this.driversTableAdapter = new Lab2BD1.KursWorkDataSetTableAdapters.DriversTableAdapter();
            this.heapsTableAdapter = new Lab2BD1.KursWorkDataSetTableAdapters.HeapsTableAdapter();
            this.racesTableAdapter = new Lab2BD1.KursWorkDataSetTableAdapters.RacesTableAdapter();
            this.roadsTableAdapter = new Lab2BD1.KursWorkDataSetTableAdapters.RoadsTableAdapter();
            this.startsTableAdapter = new Lab2BD1.KursWorkDataSetTableAdapters.StartsTableAdapter();
            this.tableAdapterManager = new Lab2BD1.KursWorkDataSetTableAdapters.TableAdapterManager();
            this.editStartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStartsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStartsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStartsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursWorkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursWorkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heapsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButtonSave});
            this.bindingNavigator1.Location = new System.Drawing.Point(393, 426);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(388, 38);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 26);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 26);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 26);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 26);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(56, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 26);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 26);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(34, 26);
            this.toolStripButtonSave.Text = "Сохранить";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(781, 332);
            this.dataGridView1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem7,
            this.editHeapFormToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.automationToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.editStartsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(965, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDrivers,
            this.toolStripMenuItemRoads,
            this.toolStripMenuItemHeaps,
            this.autosToolStripMenuItem,
            this.classesToolStripMenuItem,
            this.racesToolStripMenuItem,
            this.startsToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(102, 32);
            this.toolStripMenuItem3.Text = "Database";
            // 
            // toolStripMenuItemDrivers
            // 
            this.toolStripMenuItemDrivers.Name = "toolStripMenuItemDrivers";
            this.toolStripMenuItemDrivers.Size = new System.Drawing.Size(171, 34);
            this.toolStripMenuItemDrivers.Text = "Drivers";
            this.toolStripMenuItemDrivers.Click += new System.EventHandler(this.toolStripMenuItemDrivers_Click);
            // 
            // toolStripMenuItemRoads
            // 
            this.toolStripMenuItemRoads.Name = "toolStripMenuItemRoads";
            this.toolStripMenuItemRoads.Size = new System.Drawing.Size(171, 34);
            this.toolStripMenuItemRoads.Text = "Roads";
            this.toolStripMenuItemRoads.Click += new System.EventHandler(this.toolStripMenuItemRoads_Click);
            // 
            // toolStripMenuItemHeaps
            // 
            this.toolStripMenuItemHeaps.Name = "toolStripMenuItemHeaps";
            this.toolStripMenuItemHeaps.Size = new System.Drawing.Size(171, 34);
            this.toolStripMenuItemHeaps.Text = "Heaps";
            this.toolStripMenuItemHeaps.Click += new System.EventHandler(this.toolStripMenuItemHeaps_Click);
            // 
            // autosToolStripMenuItem
            // 
            this.autosToolStripMenuItem.Name = "autosToolStripMenuItem";
            this.autosToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.autosToolStripMenuItem.Text = "Autos";
            this.autosToolStripMenuItem.Click += new System.EventHandler(this.autosToolStripMenuItem_Click);
            // 
            // classesToolStripMenuItem
            // 
            this.classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            this.classesToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.classesToolStripMenuItem.Text = "Classes";
            this.classesToolStripMenuItem.Click += new System.EventHandler(this.classesToolStripMenuItem_Click);
            // 
            // racesToolStripMenuItem
            // 
            this.racesToolStripMenuItem.Name = "racesToolStripMenuItem";
            this.racesToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.racesToolStripMenuItem.Text = "Races";
            this.racesToolStripMenuItem.Click += new System.EventHandler(this.racesToolStripMenuItem_Click);
            // 
            // startsToolStripMenuItem
            // 
            this.startsToolStripMenuItem.Name = "startsToolStripMenuItem";
            this.startsToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.startsToolStripMenuItem.Text = "Starts";
            this.startsToolStripMenuItem.Click += new System.EventHandler(this.startsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemChangingHeap,
            this.qUeryToolStripMenuItem});
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(65, 29);
            this.toolStripMenuItem7.Text = "View";
            // 
            // toolStripMenuItemChangingHeap
            // 
            this.toolStripMenuItemChangingHeap.Name = "toolStripMenuItemChangingHeap";
            this.toolStripMenuItemChangingHeap.Size = new System.Drawing.Size(237, 34);
            this.toolStripMenuItemChangingHeap.Text = "Changing Heap";
            this.toolStripMenuItemChangingHeap.Click += new System.EventHandler(this.toolStripMenuItemChangingHeap_Click);
            // 
            // qUeryToolStripMenuItem
            // 
            this.qUeryToolStripMenuItem.Name = "qUeryToolStripMenuItem";
            this.qUeryToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.qUeryToolStripMenuItem.Text = "QueryEdit";
            this.qUeryToolStripMenuItem.Click += new System.EventHandler(this.qUeryToolStripMenuItem_Click);
            // 
            // editHeapFormToolStripMenuItem
            // 
            this.editHeapFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.editHeapFormToolStripMenuItem.Name = "editHeapFormToolStripMenuItem";
            this.editHeapFormToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.editHeapFormToolStripMenuItem.Text = "Edit Heap";
            this.editHeapFormToolStripMenuItem.Visible = false;
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.filterToolStripMenuItem.Text = "Filter";
            this.filterToolStripMenuItem.Visible = false;
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberOfHeapsToolStripMenuItem,
            this.averageRideToolStripMenuItem,
            this.ridesForDriversToolStripMenuItem,
            this.racesNumberToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // numberOfHeapsToolStripMenuItem
            // 
            this.numberOfHeapsToolStripMenuItem.Name = "numberOfHeapsToolStripMenuItem";
            this.numberOfHeapsToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.numberOfHeapsToolStripMenuItem.Text = "Number of heaps";
            this.numberOfHeapsToolStripMenuItem.Click += new System.EventHandler(this.numberOfHeapsToolStripMenuItem_Click);
            // 
            // averageRideToolStripMenuItem
            // 
            this.averageRideToolStripMenuItem.Name = "averageRideToolStripMenuItem";
            this.averageRideToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.averageRideToolStripMenuItem.Text = "Average ride";
            this.averageRideToolStripMenuItem.Click += new System.EventHandler(this.averageRideToolStripMenuItem_Click);
            // 
            // ridesForDriversToolStripMenuItem
            // 
            this.ridesForDriversToolStripMenuItem.Name = "ridesForDriversToolStripMenuItem";
            this.ridesForDriversToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.ridesForDriversToolStripMenuItem.Text = "Rides for drivers";
            this.ridesForDriversToolStripMenuItem.Click += new System.EventHandler(this.ridesForDriversToolStripMenuItem_Click);
            // 
            // racesNumberToolStripMenuItem
            // 
            this.racesNumberToolStripMenuItem.Name = "racesNumberToolStripMenuItem";
            this.racesNumberToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.racesNumberToolStripMenuItem.Text = "Races number";
            this.racesNumberToolStripMenuItem.Click += new System.EventHandler(this.racesNumberToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passForHeapToolStripMenuItem,
            this.racesResultsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // passForHeapToolStripMenuItem
            // 
            this.passForHeapToolStripMenuItem.Name = "passForHeapToolStripMenuItem";
            this.passForHeapToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
            this.passForHeapToolStripMenuItem.Text = "Pass for heap";
            this.passForHeapToolStripMenuItem.Click += new System.EventHandler(this.passForHeapToolStripMenuItem_Click);
            // 
            // racesResultsToolStripMenuItem
            // 
            this.racesResultsToolStripMenuItem.Name = "racesResultsToolStripMenuItem";
            this.racesResultsToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
            this.racesResultsToolStripMenuItem.Text = "Races results";
            this.racesResultsToolStripMenuItem.Click += new System.EventHandler(this.racesResultsToolStripMenuItem_Click);
            // 
            // automationToolStripMenuItem
            // 
            this.automationToolStripMenuItem.Name = "automationToolStripMenuItem";
            this.automationToolStripMenuItem.Size = new System.Drawing.Size(123, 29);
            this.automationToolStripMenuItem.Text = "Automation";
            this.automationToolStripMenuItem.Click += new System.EventHandler(this.automationToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.dateToolStripMenuItem,
            this.numberToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.sortToolStripMenuItem.Text = "Sort by...";
            this.sortToolStripMenuItem.Visible = false;
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascNameToolStripMenuItem,
            this.descNameToolStripMenuItem});
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.nameToolStripMenuItem.Text = "Name";
            // 
            // ascNameToolStripMenuItem
            // 
            this.ascNameToolStripMenuItem.Name = "ascNameToolStripMenuItem";
            this.ascNameToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ascNameToolStripMenuItem.Text = "Asc";
            this.ascNameToolStripMenuItem.Click += new System.EventHandler(this.ascNameToolStripMenuItem_Click);
            // 
            // descNameToolStripMenuItem
            // 
            this.descNameToolStripMenuItem.Name = "descNameToolStripMenuItem";
            this.descNameToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.descNameToolStripMenuItem.Text = "Desc";
            this.descNameToolStripMenuItem.Click += new System.EventHandler(this.descNameToolStripMenuItem_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascDateToolStripMenuItem2,
            this.descDateToolStripMenuItem2});
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dateToolStripMenuItem.Text = "Date";
            // 
            // ascDateToolStripMenuItem2
            // 
            this.ascDateToolStripMenuItem2.Name = "ascDateToolStripMenuItem2";
            this.ascDateToolStripMenuItem2.Size = new System.Drawing.Size(270, 34);
            this.ascDateToolStripMenuItem2.Text = "Asc";
            this.ascDateToolStripMenuItem2.Click += new System.EventHandler(this.ascDateToolStripMenuItem2_Click);
            // 
            // descDateToolStripMenuItem2
            // 
            this.descDateToolStripMenuItem2.Name = "descDateToolStripMenuItem2";
            this.descDateToolStripMenuItem2.Size = new System.Drawing.Size(270, 34);
            this.descDateToolStripMenuItem2.Text = "Desc";
            this.descDateToolStripMenuItem2.Click += new System.EventHandler(this.descDateToolStripMenuItem2_Click);
            // 
            // numberToolStripMenuItem
            // 
            this.numberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascNumberToolStripMenuItem1,
            this.descNumberToolStripMenuItem1});
            this.numberToolStripMenuItem.Name = "numberToolStripMenuItem";
            this.numberToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.numberToolStripMenuItem.Text = "Number";
            // 
            // ascNumberToolStripMenuItem1
            // 
            this.ascNumberToolStripMenuItem1.Name = "ascNumberToolStripMenuItem1";
            this.ascNumberToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.ascNumberToolStripMenuItem1.Text = "Asc";
            this.ascNumberToolStripMenuItem1.Click += new System.EventHandler(this.ascNumberToolStripMenuItem1_Click);
            // 
            // descNumberToolStripMenuItem1
            // 
            this.descNumberToolStripMenuItem1.Name = "descNumberToolStripMenuItem1";
            this.descNumberToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.descNumberToolStripMenuItem1.Text = "Desc";
            this.descNumberToolStripMenuItem1.Click += new System.EventHandler(this.descNumberToolStripMenuItem1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(12, 48);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 24);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "----";
            // 
            // autosBindingSource
            // 
            this.autosBindingSource.DataMember = "Autos";
            this.autosBindingSource.DataSource = this.kursWorkBindingSource;
            // 
            // kursWorkBindingSource
            // 
            this.kursWorkBindingSource.DataSource = this.kursWorkDataSet;
            this.kursWorkBindingSource.Position = 0;
            // 
            // kursWorkDataSet
            // 
            this.kursWorkDataSet.DataSetName = "KursWorkDataSet";
            this.kursWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "Classes";
            this.classesBindingSource.DataSource = this.kursWorkBindingSource;
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataMember = "Drivers";
            this.driversBindingSource.DataSource = this.kursWorkBindingSource;
            // 
            // heapsBindingSource
            // 
            this.heapsBindingSource.DataMember = "Heaps";
            this.heapsBindingSource.DataSource = this.kursWorkBindingSource;
            // 
            // racesBindingSource
            // 
            this.racesBindingSource.DataMember = "Races";
            this.racesBindingSource.DataSource = this.kursWorkBindingSource;
            // 
            // roadsBindingSource
            // 
            this.roadsBindingSource.DataMember = "Roads";
            this.roadsBindingSource.DataSource = this.kursWorkBindingSource;
            // 
            // startsBindingSource
            // 
            this.startsBindingSource.DataMember = "Starts";
            this.startsBindingSource.DataSource = this.kursWorkBindingSource;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(934, 461);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.Visible = false;
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Location = new System.Drawing.Point(799, 157);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(134, 26);
            this.SearchtextBox.TabIndex = 5;
            this.SearchtextBox.Visible = false;
            // 
            // comboBoxDrivers
            // 
            this.comboBoxDrivers.FormattingEnabled = true;
            this.comboBoxDrivers.Items.AddRange(new object[] {
            "Lastname",
            "Country"});
            this.comboBoxDrivers.Location = new System.Drawing.Point(799, 110);
            this.comboBoxDrivers.Name = "comboBoxDrivers";
            this.comboBoxDrivers.Size = new System.Drawing.Size(121, 28);
            this.comboBoxDrivers.TabIndex = 6;
            this.comboBoxDrivers.Visible = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(799, 202);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(103, 32);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Visible = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxRaces
            // 
            this.comboBoxRaces.FormattingEnabled = true;
            this.comboBoxRaces.Items.AddRange(new object[] {
            "Race_Name",
            "Class_Name"});
            this.comboBoxRaces.Location = new System.Drawing.Point(812, 110);
            this.comboBoxRaces.Name = "comboBoxRaces";
            this.comboBoxRaces.Size = new System.Drawing.Size(121, 28);
            this.comboBoxRaces.TabIndex = 8;
            this.comboBoxRaces.Visible = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(942, 411);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(22, 10);
            this.dataGridView3.TabIndex = 9;
            this.dataGridView3.Visible = false;
            // 
            // autosTableAdapter
            // 
            this.autosTableAdapter.ClearBeforeFill = true;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // driversTableAdapter
            // 
            this.driversTableAdapter.ClearBeforeFill = true;
            // 
            // heapsTableAdapter
            // 
            this.heapsTableAdapter.ClearBeforeFill = true;
            // 
            // racesTableAdapter
            // 
            this.racesTableAdapter.ClearBeforeFill = true;
            // 
            // roadsTableAdapter
            // 
            this.roadsTableAdapter.ClearBeforeFill = true;
            // 
            // startsTableAdapter
            // 
            this.startsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutosTableAdapter = this.autosTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassesTableAdapter = this.classesTableAdapter;
            this.tableAdapterManager.DriversTableAdapter = this.driversTableAdapter;
            this.tableAdapterManager.HeapsTableAdapter = this.heapsTableAdapter;
            this.tableAdapterManager.RacesTableAdapter = this.racesTableAdapter;
            this.tableAdapterManager.RoadsTableAdapter = this.roadsTableAdapter;
            this.tableAdapterManager.StartsTableAdapter = this.startsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Lab2BD1.KursWorkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // editStartsToolStripMenuItem
            // 
            this.editStartsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStartsToolStripMenuItem1,
            this.updateStartsToolStripMenuItem1,
            this.deleteStartsToolStripMenuItem1});
            this.editStartsToolStripMenuItem.Name = "editStartsToolStripMenuItem";
            this.editStartsToolStripMenuItem.Size = new System.Drawing.Size(58, 32);
            this.editStartsToolStripMenuItem.Text = "Edit";
            this.editStartsToolStripMenuItem.Visible = false;
            // 
            // addStartsToolStripMenuItem1
            // 
            this.addStartsToolStripMenuItem1.Name = "addStartsToolStripMenuItem1";
            this.addStartsToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.addStartsToolStripMenuItem1.Text = "Add";
            this.addStartsToolStripMenuItem1.Click += new System.EventHandler(this.addStartsToolStripMenuItem1_Click);
            // 
            // updateStartsToolStripMenuItem1
            // 
            this.updateStartsToolStripMenuItem1.Name = "updateStartsToolStripMenuItem1";
            this.updateStartsToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.updateStartsToolStripMenuItem1.Text = "Update";
            this.updateStartsToolStripMenuItem1.Click += new System.EventHandler(this.updateStartsToolStripMenuItem1_Click);
            // 
            // deleteStartsToolStripMenuItem1
            // 
            this.deleteStartsToolStripMenuItem1.Name = "deleteStartsToolStripMenuItem1";
            this.deleteStartsToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.deleteStartsToolStripMenuItem1.Text = "Delete";
            this.deleteStartsToolStripMenuItem1.Click += new System.EventHandler(this.deleteStartsToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveToolStripMenuItem.Text = "s";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 557);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.comboBoxRaces);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxDrivers);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Artem Lb2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursWorkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursWorkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heapsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDrivers;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRoads;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHeaps;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemChangingHeap;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripMenuItem qUeryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editHeapFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.BindingSource kursWorkBindingSource;
        private KursWorkDataSet kursWorkDataSet;
        private System.Windows.Forms.BindingSource autosBindingSource;
        private KursWorkDataSetTableAdapters.AutosTableAdapter autosTableAdapter;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private System.Windows.Forms.BindingSource driversBindingSource;
        private System.Windows.Forms.BindingSource heapsBindingSource;
        private System.Windows.Forms.BindingSource racesBindingSource;
        private System.Windows.Forms.BindingSource roadsBindingSource;
        private KursWorkDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
        private KursWorkDataSetTableAdapters.DriversTableAdapter driversTableAdapter;
        private KursWorkDataSetTableAdapters.HeapsTableAdapter heapsTableAdapter;
        private KursWorkDataSetTableAdapters.RacesTableAdapter racesTableAdapter;
        private KursWorkDataSetTableAdapters.RoadsTableAdapter roadsTableAdapter;
        private System.Windows.Forms.BindingSource startsBindingSource;
        private KursWorkDataSetTableAdapters.StartsTableAdapter startsTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem autosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem racesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startsToolStripMenuItem;
        private KursWorkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfHeapsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageRideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ridesForDriversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem racesNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passForHeapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem racesResultsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.ComboBox comboBoxDrivers;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxRaces;
        private System.Windows.Forms.ToolStripMenuItem automationToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascDateToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem descDateToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem numberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascNumberToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem descNumberToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editStartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStartsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateStartsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteStartsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

