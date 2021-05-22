using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HW1.models;
namespace HW1
{
    public partial class Form1 : Form
    {
        private List<Employee> employee_list = new List<Employee>();
        DataTable table = new DataTable();
        string[,] map_column_to_inputs = new string[2, 5] {
           {"id_column", "first_name_column", "last_name_column", "birth_date_column", "address_column"},
           {"txt_id", "txt_first_name", "txt_last_name", "txt_birth_date", "txt_address"}
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID");
            table.Columns.Add("First Name");
            table.Columns.Add("Last Name");
            table.Columns.Add("Birth Date");
            table.Columns.Add("Address");
        }

        private void add_Click(object sender, EventArgs e)
        {
            // Method 1 - Using Model
            var employee = new Employee(txt_id.Text, txt_first_name.Text, txt_last_name.Text, txt_birth_date.Text, txt_address.Text);
            employee_list.Add(employee);
            employee_DGV.Rows.Add(employee.id, employee.first_name, employee.last_name, employee.birth_date, employee.address);

            // Method 2 - Using DataTable
            //table.Rows.Add(employee.id, employee.first_name, employee.last_name, employee.birth_date, employee.address);
            //employee_DGV.DataSource = table; 
        }

        private void clear_inputs(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = null;
                }
            }
        }

        private void reset_DGV(object sender, EventArgs e)
        {
            employee_DGV.Rows.Clear();
            table.Rows.Clear();
        }

        private void exit_form(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employee_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (var index = 0; index <= 4; index++)
            {
                var cell = map_column_to_inputs[0, index].ToString();
                TextBox dynamic_txt = (TextBox)Controls[map_column_to_inputs[1, index]];
                dynamic_txt.Text = employee_DGV.Rows[e.RowIndex].Cells[cell].Value.ToString();
            }
        }

        private void displaySearchResult(Array result)
        {
            employee_DGV.Rows.Clear();

            foreach (Employee employee in result)
            {
                employee_DGV.Rows.Add(employee.id, employee.first_name, employee.last_name, employee.birth_date, employee.address);
            }
        }

        private void search_click(object sender, EventArgs e)
        {
            var search_by = "id";

            if (search_by_txt.SelectedIndex > -1)
            {
                search_by = search_by_txt.Items[search_by_txt.SelectedIndex].ToString();
            }

            if (String.IsNullOrEmpty(txt_search.Text))
            {
                displaySearchResult(employee_list.ToArray());
            }
            else
            {
                var result = from employee in employee_list
                             where employee.GetType().GetProperty(search_by).GetValue(employee).ToString() == txt_search.Text.ToString()
                             select employee;

                displaySearchResult(result.ToArray());
            }
        }
    }
}
