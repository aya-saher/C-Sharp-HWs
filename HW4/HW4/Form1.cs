using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void attendancesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.attendancesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hW4DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hW4DataSet.courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.hW4DataSet.courses);
            // TODO: This line of code loads data into the 'hW4DataSet.teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.hW4DataSet.teachers);
            // TODO: This line of code loads data into the 'hW4DataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.hW4DataSet.rooms);
            // TODO: This line of code loads data into the 'hW4DataSet.attendances' table. You can move, or remove it, as needed.
            this.attendancesTableAdapter.Fill(this.hW4DataSet.attendances);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Room().ShowDialog();
            this.roomsTableAdapter.Fill(this.hW4DataSet.rooms);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Teacher().ShowDialog();
            this.teachersTableAdapter.Fill(this.hW4DataSet.teachers);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Course().ShowDialog();
            this.coursesTableAdapter.Fill(this.hW4DataSet.courses);
        }
    }
}
