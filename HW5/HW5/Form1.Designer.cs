namespace HW5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_comment = new System.Windows.Forms.TextBox();
            this.cmb_rooms = new System.Windows.Forms.ComboBox();
            this.cmb_teachers = new System.Windows.Forms.ComboBox();
            this.cmb_courses = new System.Windows.Forms.ComboBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.dtp_start_at = new System.Windows.Forms.DateTimePicker();
            this.dtp_leaving_at = new System.Windows.Forms.DateTimePicker();
            this.dgv_attendances = new System.Windows.Forms.DataGridView();
            this.btn_add_attendance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_attendances)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rooms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Techers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Courses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start At";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Leaving At";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Comment";
            // 
            // txt_comment
            // 
            this.txt_comment.Location = new System.Drawing.Point(99, 152);
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.Size = new System.Drawing.Size(623, 20);
            this.txt_comment.TabIndex = 7;
            // 
            // cmb_rooms
            // 
            this.cmb_rooms.FormattingEnabled = true;
            this.cmb_rooms.Location = new System.Drawing.Point(99, 41);
            this.cmb_rooms.Name = "cmb_rooms";
            this.cmb_rooms.Size = new System.Drawing.Size(121, 21);
            this.cmb_rooms.TabIndex = 8;
            // 
            // cmb_teachers
            // 
            this.cmb_teachers.FormattingEnabled = true;
            this.cmb_teachers.Location = new System.Drawing.Point(331, 41);
            this.cmb_teachers.Name = "cmb_teachers";
            this.cmb_teachers.Size = new System.Drawing.Size(121, 21);
            this.cmb_teachers.TabIndex = 9;
            // 
            // cmb_courses
            // 
            this.cmb_courses.FormattingEnabled = true;
            this.cmb_courses.Location = new System.Drawing.Point(570, 41);
            this.cmb_courses.Name = "cmb_courses";
            this.cmb_courses.Size = new System.Drawing.Size(121, 21);
            this.cmb_courses.TabIndex = 10;
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(99, 102);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(121, 20);
            this.dtp_date.TabIndex = 11;
            // 
            // dtp_start_at
            // 
            this.dtp_start_at.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_start_at.Location = new System.Drawing.Point(331, 102);
            this.dtp_start_at.Name = "dtp_start_at";
            this.dtp_start_at.Size = new System.Drawing.Size(121, 20);
            this.dtp_start_at.TabIndex = 12;
            // 
            // dtp_leaving_at
            // 
            this.dtp_leaving_at.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_leaving_at.Location = new System.Drawing.Point(570, 102);
            this.dtp_leaving_at.Name = "dtp_leaving_at";
            this.dtp_leaving_at.Size = new System.Drawing.Size(121, 20);
            this.dtp_leaving_at.TabIndex = 13;
            // 
            // dgv_attendances
            // 
            this.dgv_attendances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_attendances.Location = new System.Drawing.Point(61, 257);
            this.dgv_attendances.Name = "dgv_attendances";
            this.dgv_attendances.Size = new System.Drawing.Size(661, 194);
            this.dgv_attendances.TabIndex = 14;
            this.dgv_attendances.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_attendances_CellMouseDoubleClick);
            // 
            // btn_add_attendance
            // 
            this.btn_add_attendance.Location = new System.Drawing.Point(647, 195);
            this.btn_add_attendance.Name = "btn_add_attendance";
            this.btn_add_attendance.Size = new System.Drawing.Size(75, 23);
            this.btn_add_attendance.TabIndex = 15;
            this.btn_add_attendance.Text = "Add";
            this.btn_add_attendance.UseVisualStyleBackColor = true;
            this.btn_add_attendance.Click += new System.EventHandler(this.btn_add_attendance_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 463);
            this.Controls.Add(this.btn_add_attendance);
            this.Controls.Add(this.dgv_attendances);
            this.Controls.Add(this.dtp_leaving_at);
            this.Controls.Add(this.dtp_start_at);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.cmb_courses);
            this.Controls.Add(this.cmb_teachers);
            this.Controls.Add(this.cmb_rooms);
            this.Controls.Add(this.txt_comment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Attendances";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_attendances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_comment;
        private System.Windows.Forms.ComboBox cmb_rooms;
        private System.Windows.Forms.ComboBox cmb_teachers;
        private System.Windows.Forms.ComboBox cmb_courses;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.DateTimePicker dtp_start_at;
        private System.Windows.Forms.DateTimePicker dtp_leaving_at;
        private System.Windows.Forms.DataGridView dgv_attendances;
        private System.Windows.Forms.Button btn_add_attendance;
    }
}

