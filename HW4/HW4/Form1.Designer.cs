namespace HW4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label room_idLabel;
            System.Windows.Forms.Label teacher_idLabel;
            System.Windows.Forms.Label course_idLabel;
            System.Windows.Forms.Label attendance_dateLabel;
            System.Windows.Forms.Label satrt_timeLabel;
            System.Windows.Forms.Label leaving_timeLabel;
            System.Windows.Forms.Label commentLabel;
            this.hW4DataSet = new HW4.HW4DataSet();
            this.attendancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendancesTableAdapter = new HW4.HW4DataSetTableAdapters.attendancesTableAdapter();
            this.tableAdapterManager = new HW4.HW4DataSetTableAdapters.TableAdapterManager();
            this.attendancesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.attendancesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.attendancesDataGridView = new System.Windows.Forms.DataGridView();
            this.attendance_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.satrt_timeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.leaving_timeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new HW4.HW4DataSetTableAdapters.roomsTableAdapter();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new HW4.HW4DataSetTableAdapters.teachersTableAdapter();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new HW4.HW4DataSetTableAdapters.coursesTableAdapter();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            room_idLabel = new System.Windows.Forms.Label();
            teacher_idLabel = new System.Windows.Forms.Label();
            course_idLabel = new System.Windows.Forms.Label();
            attendance_dateLabel = new System.Windows.Forms.Label();
            satrt_timeLabel = new System.Windows.Forms.Label();
            leaving_timeLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hW4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendancesBindingNavigator)).BeginInit();
            this.attendancesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendancesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hW4DataSet
            // 
            this.hW4DataSet.DataSetName = "HW4DataSet";
            this.hW4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendancesBindingSource
            // 
            this.attendancesBindingSource.DataMember = "attendances";
            this.attendancesBindingSource.DataSource = this.hW4DataSet;
            // 
            // attendancesTableAdapter
            // 
            this.attendancesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.attendancesTableAdapter = this.attendancesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.coursesTableAdapter = this.coursesTableAdapter;
            this.tableAdapterManager.roomsTableAdapter = this.roomsTableAdapter;
            this.tableAdapterManager.teachersTableAdapter = this.teachersTableAdapter;
            this.tableAdapterManager.UpdateOrder = HW4.HW4DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // attendancesBindingNavigator
            // 
            this.attendancesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.attendancesBindingNavigator.BindingSource = this.attendancesBindingSource;
            this.attendancesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.attendancesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.attendancesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.attendancesBindingNavigatorSaveItem});
            this.attendancesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.attendancesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.attendancesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.attendancesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.attendancesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.attendancesBindingNavigator.Name = "attendancesBindingNavigator";
            this.attendancesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.attendancesBindingNavigator.Size = new System.Drawing.Size(795, 25);
            this.attendancesBindingNavigator.TabIndex = 0;
            this.attendancesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // attendancesBindingNavigatorSaveItem
            // 
            this.attendancesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.attendancesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("attendancesBindingNavigatorSaveItem.Image")));
            this.attendancesBindingNavigatorSaveItem.Name = "attendancesBindingNavigatorSaveItem";
            this.attendancesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.attendancesBindingNavigatorSaveItem.Text = "Save Data";
            this.attendancesBindingNavigatorSaveItem.Click += new System.EventHandler(this.attendancesBindingNavigatorSaveItem_Click);
            // 
            // attendancesDataGridView
            // 
            this.attendancesDataGridView.AutoGenerateColumns = false;
            this.attendancesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendancesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.attendancesDataGridView.DataSource = this.attendancesBindingSource;
            this.attendancesDataGridView.Location = new System.Drawing.Point(32, 210);
            this.attendancesDataGridView.Name = "attendancesDataGridView";
            this.attendancesDataGridView.Size = new System.Drawing.Size(744, 220);
            this.attendancesDataGridView.TabIndex = 1;
            // 
            // room_idLabel
            // 
            room_idLabel.AutoSize = true;
            room_idLabel.Location = new System.Drawing.Point(51, 69);
            room_idLabel.Name = "room_idLabel";
            room_idLabel.Size = new System.Drawing.Size(40, 13);
            room_idLabel.TabIndex = 4;
            room_idLabel.Text = "Rooms";
            // 
            // teacher_idLabel
            // 
            teacher_idLabel.AutoSize = true;
            teacher_idLabel.Location = new System.Drawing.Point(298, 66);
            teacher_idLabel.Name = "teacher_idLabel";
            teacher_idLabel.Size = new System.Drawing.Size(52, 13);
            teacher_idLabel.TabIndex = 6;
            teacher_idLabel.Text = "Teachers";
            // 
            // course_idLabel
            // 
            course_idLabel.AutoSize = true;
            course_idLabel.Location = new System.Drawing.Point(568, 66);
            course_idLabel.Name = "course_idLabel";
            course_idLabel.Size = new System.Drawing.Size(45, 13);
            course_idLabel.TabIndex = 8;
            course_idLabel.Text = "Courses";
            // 
            // attendance_dateLabel
            // 
            attendance_dateLabel.AutoSize = true;
            attendance_dateLabel.Location = new System.Drawing.Point(61, 125);
            attendance_dateLabel.Name = "attendance_dateLabel";
            attendance_dateLabel.Size = new System.Drawing.Size(30, 13);
            attendance_dateLabel.TabIndex = 10;
            attendance_dateLabel.Text = "Date";
            // 
            // attendance_dateDateTimePicker
            // 
            this.attendance_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.attendancesBindingSource, "attendance_date", true));
            this.attendance_dateDateTimePicker.Location = new System.Drawing.Point(97, 121);
            this.attendance_dateDateTimePicker.Name = "attendance_dateDateTimePicker";
            this.attendance_dateDateTimePicker.Size = new System.Drawing.Size(127, 20);
            this.attendance_dateDateTimePicker.TabIndex = 11;
            // 
            // satrt_timeLabel
            // 
            satrt_timeLabel.AutoSize = true;
            satrt_timeLabel.Location = new System.Drawing.Point(292, 125);
            satrt_timeLabel.Name = "satrt_timeLabel";
            satrt_timeLabel.Size = new System.Drawing.Size(55, 13);
            satrt_timeLabel.TabIndex = 12;
            satrt_timeLabel.Text = "Start Time";
            // 
            // satrt_timeDateTimePicker
            // 
            this.satrt_timeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.attendancesBindingSource, "satrt_time", true));
            this.satrt_timeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.satrt_timeDateTimePicker.Location = new System.Drawing.Point(353, 121);
            this.satrt_timeDateTimePicker.Name = "satrt_timeDateTimePicker";
            this.satrt_timeDateTimePicker.Size = new System.Drawing.Size(127, 20);
            this.satrt_timeDateTimePicker.TabIndex = 13;
            // 
            // leaving_timeLabel
            // 
            leaving_timeLabel.AutoSize = true;
            leaving_timeLabel.Location = new System.Drawing.Point(542, 125);
            leaving_timeLabel.Name = "leaving_timeLabel";
            leaving_timeLabel.Size = new System.Drawing.Size(71, 13);
            leaving_timeLabel.TabIndex = 14;
            leaving_timeLabel.Text = "Leaving Time";
            // 
            // leaving_timeDateTimePicker
            // 
            this.leaving_timeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.attendancesBindingSource, "leaving_time", true));
            this.leaving_timeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.leaving_timeDateTimePicker.Location = new System.Drawing.Point(619, 121);
            this.leaving_timeDateTimePicker.Name = "leaving_timeDateTimePicker";
            this.leaving_timeDateTimePicker.Size = new System.Drawing.Size(127, 20);
            this.leaving_timeDateTimePicker.TabIndex = 15;
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(40, 178);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(51, 13);
            commentLabel.TabIndex = 16;
            commentLabel.Text = "Comment";
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attendancesBindingSource, "comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(97, 175);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(649, 20);
            this.commentTextBox.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.attendancesBindingSource, "room_id", true));
            this.comboBox1.DataSource = this.roomsBindingSource;
            this.comboBox1.DisplayMember = "room_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "room_id";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.attendancesBindingSource, "teacher_id", true));
            this.comboBox2.DataSource = this.teachersBindingSource;
            this.comboBox2.DisplayMember = "teacher_name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(353, 66);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.ValueMember = "teacher_id";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.attendancesBindingSource, "course_id", true));
            this.comboBox3.DataSource = this.coursesBindingSource;
            this.comboBox3.DisplayMember = "course_name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(619, 63);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 20;
            this.comboBox3.ValueMember = "course_id";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "rooms";
            this.roomsBindingSource.DataSource = this.hW4DataSet;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "teachers";
            this.teachersBindingSource.DataSource = this.hW4DataSet;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "courses";
            this.coursesBindingSource.DataSource = this.hW4DataSet;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "room_id";
            this.dataGridViewTextBoxColumn2.DataSource = this.roomsBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "room_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Room";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "room_id";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "teacher_id";
            this.dataGridViewTextBoxColumn3.DataSource = this.teachersBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "teacher_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Teacher";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "teacher_id";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "course_id";
            this.dataGridViewTextBoxColumn4.DataSource = this.coursesBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "course_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Course";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "course_id";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "attendance_date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "satrt_time";
            this.dataGridViewTextBoxColumn6.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "leaving_time";
            this.dataGridViewTextBoxColumn7.HeaderText = "Leaving Time";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "comment";
            this.dataGridViewTextBoxColumn8.HeaderText = "Comment";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(480, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(746, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 463);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(room_idLabel);
            this.Controls.Add(teacher_idLabel);
            this.Controls.Add(course_idLabel);
            this.Controls.Add(attendance_dateLabel);
            this.Controls.Add(this.attendance_dateDateTimePicker);
            this.Controls.Add(satrt_timeLabel);
            this.Controls.Add(this.satrt_timeDateTimePicker);
            this.Controls.Add(leaving_timeLabel);
            this.Controls.Add(this.leaving_timeDateTimePicker);
            this.Controls.Add(commentLabel);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.attendancesDataGridView);
            this.Controls.Add(this.attendancesBindingNavigator);
            this.Name = "Form1";
            this.Text = "Attendance Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hW4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendancesBindingNavigator)).EndInit();
            this.attendancesBindingNavigator.ResumeLayout(false);
            this.attendancesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendancesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource attendancesBindingSource;
        private HW4DataSetTableAdapters.attendancesTableAdapter attendancesTableAdapter;
        private HW4DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator attendancesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton attendancesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView attendancesDataGridView;
        private System.Windows.Forms.DateTimePicker attendance_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker satrt_timeDateTimePicker;
        private System.Windows.Forms.DateTimePicker leaving_timeDateTimePicker;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public HW4DataSetTableAdapters.roomsTableAdapter roomsTableAdapter;
        public HW4DataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
        public HW4DataSetTableAdapters.coursesTableAdapter coursesTableAdapter;
        public System.Windows.Forms.BindingSource roomsBindingSource;
        public System.Windows.Forms.BindingSource teachersBindingSource;
        public System.Windows.Forms.BindingSource coursesBindingSource;
        public HW4DataSet hW4DataSet;
    }
}

