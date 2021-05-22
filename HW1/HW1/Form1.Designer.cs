namespace HW1
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
            this.search_by_txt = new System.Windows.Forms.ComboBox();
            this.address_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth_date_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_DGV = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_birth_date = new System.Windows.Forms.TextBox();
            this.txt_last_name = new System.Windows.Forms.TextBox();
            this.txt_first_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.birth_date = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employee_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // search_by_txt
            // 
            this.search_by_txt.FormattingEnabled = true;
            this.search_by_txt.Items.AddRange(new object[] {
            "id",
            "first_name",
            "last_name",
            "birth_date",
            "address"});
            this.search_by_txt.Location = new System.Drawing.Point(370, 223);
            this.search_by_txt.Name = "search_by_txt";
            this.search_by_txt.Size = new System.Drawing.Size(94, 21);
            this.search_by_txt.TabIndex = 23;
            // 
            // address_column
            // 
            this.address_column.HeaderText = "Address";
            this.address_column.Name = "address_column";
            // 
            // birth_date_column
            // 
            this.birth_date_column.HeaderText = "Birth Date";
            this.birth_date_column.Name = "birth_date_column";
            // 
            // last_name_column
            // 
            this.last_name_column.HeaderText = "First Name";
            this.last_name_column.Name = "last_name_column";
            // 
            // first_name_column
            // 
            this.first_name_column.HeaderText = "First Name";
            this.first_name_column.Name = "first_name_column";
            // 
            // id_column
            // 
            this.id_column.HeaderText = "ID";
            this.id_column.Name = "id_column";
            // 
            // employee_DGV
            // 
            this.employee_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_column,
            this.first_name_column,
            this.last_name_column,
            this.birth_date_column,
            this.address_column});
            this.employee_DGV.Location = new System.Drawing.Point(23, 253);
            this.employee_DGV.Name = "employee_DGV";
            this.employee_DGV.Size = new System.Drawing.Size(544, 150);
            this.employee_DGV.TabIndex = 22;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(470, 222);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(95, 23);
            this.search.TabIndex = 21;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(396, 421);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.exit_form);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.reset_DGV);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clear_inputs);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(98, 150);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(244, 23);
            this.add.TabIndex = 17;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(23, 223);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(341, 20);
            this.txt_search.TabIndex = 16;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(98, 124);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(244, 20);
            this.txt_address.TabIndex = 15;
            // 
            // txt_birth_date
            // 
            this.txt_birth_date.Location = new System.Drawing.Point(98, 98);
            this.txt_birth_date.Name = "txt_birth_date";
            this.txt_birth_date.Size = new System.Drawing.Size(244, 20);
            this.txt_birth_date.TabIndex = 14;
            // 
            // txt_last_name
            // 
            this.txt_last_name.Location = new System.Drawing.Point(98, 73);
            this.txt_last_name.Name = "txt_last_name";
            this.txt_last_name.Size = new System.Drawing.Size(244, 20);
            this.txt_last_name.TabIndex = 13;
            // 
            // txt_first_name
            // 
            this.txt_first_name.Location = new System.Drawing.Point(98, 49);
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.Size = new System.Drawing.Size(244, 20);
            this.txt_first_name.TabIndex = 12;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(98, 24);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(244, 20);
            this.txt_id.TabIndex = 11;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(20, 127);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(45, 13);
            this.address.TabIndex = 9;
            this.address.Text = "Address";
            // 
            // birth_date
            // 
            this.birth_date.AutoSize = true;
            this.birth_date.Location = new System.Drawing.Point(20, 101);
            this.birth_date.Name = "birth_date";
            this.birth_date.Size = new System.Drawing.Size(54, 13);
            this.birth_date.TabIndex = 8;
            this.birth_date.Text = "Birth Date";
            // 
            // last_name
            // 
            this.last_name.AutoSize = true;
            this.last_name.Location = new System.Drawing.Point(20, 76);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(58, 13);
            this.last_name.TabIndex = 7;
            this.last_name.Text = "Last Name";
            // 
            // first_name
            // 
            this.first_name.AutoSize = true;
            this.first_name.Location = new System.Drawing.Point(20, 52);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(57, 13);
            this.first_name.TabIndex = 10;
            this.first_name.Text = "First Name";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(20, 27);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 13);
            this.id.TabIndex = 6;
            this.id.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 459);
            this.Controls.Add(this.search_by_txt);
            this.Controls.Add(this.employee_DGV);
            this.Controls.Add(this.search);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_birth_date);
            this.Controls.Add(this.txt_last_name);
            this.Controls.Add(this.txt_first_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.address);
            this.Controls.Add(this.birth_date);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employee_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox search_by_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth_date_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_column;
        private System.Windows.Forms.DataGridView employee_DGV;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_birth_date;
        private System.Windows.Forms.TextBox txt_last_name;
        private System.Windows.Forms.TextBox txt_first_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label birth_date;
        private System.Windows.Forms.Label last_name;
        private System.Windows.Forms.Label first_name;
        private System.Windows.Forms.Label id;
    }
}

