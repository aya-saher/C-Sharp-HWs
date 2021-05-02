using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HW5.libraries;
using HW5.models;

namespace HW5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_attendances.DataSource = DatabaseOperation.get(new DataTable(), (new Attendance()).all());

            getCourses(new DataTable());

            getTeachers(new DataTable());

            getRooms(new DataTable());
        }

        private void getCourses(DataTable table)
        {
            table.Columns.Add("course_id", typeof(string));
            table.Columns.Add("course_name", typeof(string));
            cmb_courses.ValueMember = "course_id";
            cmb_courses.DisplayMember = "course_name";
            cmb_courses.DataSource = DatabaseOperation.get(table, (new Course()).all());
        }

        private void getTeachers(DataTable table)
        {
            table.Columns.Add("teacher_id", typeof(string));
            table.Columns.Add("teacher_name", typeof(string));
            cmb_teachers.ValueMember = "teacher_id";
            cmb_teachers.DisplayMember = "teacher_name";
            cmb_teachers.DataSource = DatabaseOperation.get(table, (new Teacher()).all());
        }

        private void getRooms(DataTable table)
        {
            table.Columns.Add("room_id", typeof(string));
            table.Columns.Add("room_name", typeof(string));
            cmb_rooms.ValueMember = "room_id";
            cmb_rooms.DisplayMember = "room_name";
            cmb_rooms.DataSource = DatabaseOperation.get(table, (new Room()).all());
        }

        private void btn_add_attendance_Click(object sender, EventArgs e)
        {
            string query = (new Attendance()).insert(
               cmb_teachers.SelectedValue.ToString(),
               cmb_courses.SelectedValue.ToString(),
               cmb_rooms.SelectedValue.ToString(),
               dtp_date.Value.ToString(),
               dtp_start_at.Value.ToString(),
               dtp_leaving_at.Value.ToString(),
               txt_comment.Text
            );
            DatabaseOperation.create(query);

            dgv_attendances.DataSource = DatabaseOperation.get(new DataTable(), (new Attendance()).all());
        }

        private void dgv_attendances_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                cmb_teachers.Text = dgv_attendances.Rows[e.RowIndex].Cells["Teacher"].Value.ToString();
                cmb_courses.Text = dgv_attendances.Rows[e.RowIndex].Cells["Course"].Value.ToString();
                cmb_rooms.Text = dgv_attendances.Rows[e.RowIndex].Cells["Room"].Value.ToString();
                dtp_date.Text = dgv_attendances.Rows[e.RowIndex].Cells["Date"].Value.ToString();
                dtp_start_at.Text = dgv_attendances.Rows[e.RowIndex].Cells["Start At"].Value.ToString();
                dtp_leaving_at.Text = dgv_attendances.Rows[e.RowIndex].Cells["Leaving At"].Value.ToString();
                txt_comment.Text = dgv_attendances.Rows[e.RowIndex].Cells["comment"].Value.ToString();
            }
        }
    }
}
