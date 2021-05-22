namespace HW2
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
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_course = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.cmb_course = new System.Windows.Forms.ComboBox();
            this.cmb_teacher = new System.Windows.Forms.ComboBox();
            this.lbl_teacher = new System.Windows.Forms.Label();
            this.cmb_room = new System.Windows.Forms.ComboBox();
            this.lbl_room = new System.Windows.Forms.Label();
            this.lbl_start_time = new System.Windows.Forms.Label();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_leaving = new System.Windows.Forms.DateTimePicker();
            this.leaving_time = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.dgv_attendance = new System.Windows.Forms.DataGridView();
            this.lbl_comment = new System.Windows.Forms.Label();
            this.txt_comment = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_attendance)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_date.Location = new System.Drawing.Point(65, 50);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(39, 18);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "Date";
            // 
            // lbl_course
            // 
            this.lbl_course.AutoSize = true;
            this.lbl_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_course.Location = new System.Drawing.Point(298, 50);
            this.lbl_course.Name = "lbl_course";
            this.lbl_course.Size = new System.Drawing.Size(101, 18);
            this.lbl_course.TabIndex = 1;
            this.lbl_course.Text = "Course Name";
            // 
            // dtp_date
            // 
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(119, 50);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(150, 20);
            this.dtp_date.TabIndex = 2;
            // 
            // cmb_course
            // 
            this.cmb_course.FormattingEnabled = true;
            this.cmb_course.Location = new System.Drawing.Point(405, 51);
            this.cmb_course.Name = "cmb_course";
            this.cmb_course.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_course.Size = new System.Drawing.Size(150, 21);
            this.cmb_course.TabIndex = 3;
            this.cmb_course.SelectionChangeCommitted += new System.EventHandler(this.cmb_course_SelectionChangeCommitted);
            // 
            // cmb_teacher
            // 
            this.cmb_teacher.FormattingEnabled = true;
            this.cmb_teacher.Location = new System.Drawing.Point(693, 53);
            this.cmb_teacher.Name = "cmb_teacher";
            this.cmb_teacher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_teacher.Size = new System.Drawing.Size(150, 21);
            this.cmb_teacher.TabIndex = 5;
            this.cmb_teacher.SelectionChangeCommitted += new System.EventHandler(this.cmb_teacher_SelectionChangeCommitted);
            // 
            // lbl_teacher
            // 
            this.lbl_teacher.AutoSize = true;
            this.lbl_teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_teacher.Location = new System.Drawing.Point(586, 52);
            this.lbl_teacher.Name = "lbl_teacher";
            this.lbl_teacher.Size = new System.Drawing.Size(106, 18);
            this.lbl_teacher.TabIndex = 4;
            this.lbl_teacher.Text = "Teacher Name";
            // 
            // cmb_room
            // 
            this.cmb_room.FormattingEnabled = true;
            this.cmb_room.Location = new System.Drawing.Point(119, 98);
            this.cmb_room.Name = "cmb_room";
            this.cmb_room.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_room.Size = new System.Drawing.Size(150, 21);
            this.cmb_room.TabIndex = 7;
            this.cmb_room.SelectionChangeCommitted += new System.EventHandler(this.cmb_room_SelectionChangeCommitted);
            // 
            // lbl_room
            // 
            this.lbl_room.AutoSize = true;
            this.lbl_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_room.Location = new System.Drawing.Point(12, 97);
            this.lbl_room.Name = "lbl_room";
            this.lbl_room.Size = new System.Drawing.Size(94, 18);
            this.lbl_room.TabIndex = 6;
            this.lbl_room.Text = "Room Name";
            // 
            // lbl_start_time
            // 
            this.lbl_start_time.AutoSize = true;
            this.lbl_start_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_start_time.Location = new System.Drawing.Point(323, 98);
            this.lbl_start_time.Name = "lbl_start_time";
            this.lbl_start_time.Size = new System.Drawing.Size(76, 18);
            this.lbl_start_time.TabIndex = 8;
            this.lbl_start_time.Text = "Start Time";
            // 
            // dtp_start
            // 
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_start.Location = new System.Drawing.Point(405, 99);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(150, 20);
            this.dtp_start.TabIndex = 9;
            // 
            // dtp_leaving
            // 
            this.dtp_leaving.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_leaving.Location = new System.Drawing.Point(695, 102);
            this.dtp_leaving.Name = "dtp_leaving";
            this.dtp_leaving.Size = new System.Drawing.Size(150, 20);
            this.dtp_leaving.TabIndex = 11;
            // 
            // leaving_time
            // 
            this.leaving_time.AutoSize = true;
            this.leaving_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.leaving_time.Location = new System.Drawing.Point(595, 101);
            this.leaving_time.Name = "leaving_time";
            this.leaving_time.Size = new System.Drawing.Size(95, 18);
            this.leaving_time.TabIndex = 10;
            this.leaving_time.Text = "Leaving Time";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_save.Location = new System.Drawing.Point(697, 187);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(148, 27);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgv_attendance
            // 
            this.dgv_attendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_attendance.Location = new System.Drawing.Point(15, 220);
            this.dgv_attendance.Name = "dgv_attendance";
            this.dgv_attendance.Size = new System.Drawing.Size(898, 233);
            this.dgv_attendance.TabIndex = 13;
            this.dgv_attendance.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_attendance_CellMouseDoubleClick);
            // 
            // lbl_comment
            // 
            this.lbl_comment.AutoSize = true;
            this.lbl_comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_comment.Location = new System.Drawing.Point(30, 147);
            this.lbl_comment.Name = "lbl_comment";
            this.lbl_comment.Size = new System.Drawing.Size(74, 18);
            this.lbl_comment.TabIndex = 14;
            this.lbl_comment.Text = "Comment";
            // 
            // txt_comment
            // 
            this.txt_comment.Location = new System.Drawing.Point(119, 148);
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.Size = new System.Drawing.Size(726, 20);
            this.txt_comment.TabIndex = 15;
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_edit.Location = new System.Drawing.Point(542, 187);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(148, 27);
            this.btn_edit.TabIndex = 16;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_clear.Location = new System.Drawing.Point(388, 187);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(148, 27);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 465);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_comment);
            this.Controls.Add(this.lbl_comment);
            this.Controls.Add(this.dgv_attendance);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dtp_leaving);
            this.Controls.Add(this.leaving_time);
            this.Controls.Add(this.dtp_start);
            this.Controls.Add(this.lbl_start_time);
            this.Controls.Add(this.cmb_room);
            this.Controls.Add(this.lbl_room);
            this.Controls.Add(this.cmb_teacher);
            this.Controls.Add(this.lbl_teacher);
            this.Controls.Add(this.cmb_course);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.lbl_course);
            this.Controls.Add(this.lbl_date);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_attendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_course;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.ComboBox cmb_course;
        private System.Windows.Forms.ComboBox cmb_teacher;
        private System.Windows.Forms.Label lbl_teacher;
        private System.Windows.Forms.ComboBox cmb_room;
        private System.Windows.Forms.Label lbl_room;
        private System.Windows.Forms.Label lbl_start_time;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_leaving;
        private System.Windows.Forms.Label leaving_time;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dgv_attendance;
        private System.Windows.Forms.Label lbl_comment;
        private System.Windows.Forms.TextBox txt_comment;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_clear;
    }
}

