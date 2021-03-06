using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HW3.model;
using HW3.helper;

namespace HW2
{
    public partial class Form1 : Form
    {
        private AttendanceManagement attendance;
        BindingSource data_source = new BindingSource();
        private int selected_item;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            attendance = new AttendanceManagement();
            dgv_attendance.DataSource = data_source;

            FillCourses();
            FillTeachers();
            FillRooms();

            btn_edit.Enabled = false;
            btn_clear.Enabled = false;
        }


        private void FillCourses()
        {
            cmb_course.DataSource = attendance.getCourses();
            cmb_course.SelectedIndex = -1;
        }


        private void FillTeachers()
        {
            cmb_teacher.DataSource = attendance.getTeachers();
            cmb_teacher.SelectedIndex = -1;
        }


        private void FillRooms()
        {
            cmb_room.DataSource = attendance.getRooms();
            cmb_room.SelectedIndex = -1;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            dgv_attendance.DataSource = null;
            attendance.SaveAttendance(((Teacher)cmb_teacher.SelectedItem).TeacherName, ((Course)cmb_course.SelectedItem).CourseName, ((Room)cmb_room.SelectedItem).RoomName,
                                    dtp_date.Value.ToString(), dtp_start.Value.ToString(), dtp_leaving.Value.ToString(), txt_comment.Text);

            data_source.DataSource = attendance.GetAttendances();
            dgv_attendance.DataSource = data_source;
        }

        private void cmb_course_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string value = "";


            int id = ((Course)((ComboBox)sender).SelectedItem).CourseId;

            if (id != 0)
                return;

            if (Prompt.InputBox("New Course", "New Course Name:", ref value) == DialogResult.OK)
                if (value.Trim().Length > 0)
                {
                    attendance.addNewCourse(value.Trim());
                    FillCourses();
                }
        }

        private void cmb_teacher_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string value = "";


            int id = ((Teacher)((ComboBox)sender).SelectedItem).TeacherId;

            if (id != 0)
                return;

            if (Prompt.InputBox("New Teacher", "New Teacher Name:", ref value) == DialogResult.OK)
                if (value.Trim().Length > 0)
                {
                    attendance.addNewTeacher(value.Trim());
                    FillTeachers();
                }
        }

        private void cmb_room_SelectionChangeCommitted(object sender, EventArgs e)
        { 
            string value = "";


            int id = ((Room)((ComboBox)sender).SelectedItem).RoomId;

            if (id != 0)
                return;

            if (Prompt.InputBox("New Room", "New Room Name:", ref value) == DialogResult.OK)
                if (value.Trim().Length > 0)
                {
                    attendance.addNewRoom(value.Trim());
                    FillRooms();
                }
        }

        private void dgv_attendance_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected_item = e.RowIndex;

                btn_edit.Enabled = true;
                btn_clear.Enabled = true;

                cmb_teacher.Text = dgv_attendance.Rows[e.RowIndex].Cells["teacher"].Value.ToString();
                cmb_course.Text = dgv_attendance.Rows[e.RowIndex].Cells["course"].Value.ToString();
                cmb_room.Text = dgv_attendance.Rows[e.RowIndex].Cells["room"].Value.ToString();
                dtp_date.Text = dgv_attendance.Rows[e.RowIndex].Cells["date"].Value.ToString();
                dtp_start.Text = dgv_attendance.Rows[e.RowIndex].Cells["start_time"].Value.ToString();
                dtp_leaving.Text = dgv_attendance.Rows[e.RowIndex].Cells["leaving_time"].Value.ToString();
                txt_comment.Text = dgv_attendance.Rows[e.RowIndex].Cells["comment"].Value.ToString();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            dgv_attendance.Rows[selected_item].Cells["teacher"].Value = cmb_teacher.Text;
            dgv_attendance.Rows[selected_item].Cells["course"].Value = cmb_course.Text;
            dgv_attendance.Rows[selected_item].Cells["room"].Value = cmb_room.Text;
            dgv_attendance.Rows[selected_item].Cells["date"].Value = dtp_date.Text;
            dgv_attendance.Rows[selected_item].Cells["start_time"].Value = dtp_start.Text;
            dgv_attendance.Rows[selected_item].Cells["leaving_time"].Value = dtp_leaving.Text;
            dgv_attendance.Rows[selected_item].Cells["comment"].Value = txt_comment.Text;

            btn_edit.Enabled = false;
            btn_clear.Enabled = false;
            selected_item = -1;
            clearFields();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    ((TextBox)ctrl).Clear();

                }
                else if (ctrl.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                }
            }
        }

        private void clearFields()
        {

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    ((TextBox)ctrl).Clear();

                }
                else if (ctrl.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                }
            }
        }
    }
}
