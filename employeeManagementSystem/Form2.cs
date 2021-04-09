using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employeeManagementSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dashboardStats();
            customise_design();
            datagridview();
            populateBranchGrid();
            datagridPopulate();
        }

 
        private void dashboardStats()
        {
            string sql = "select count(*) from employee";

            SqlConnection connection = new SqlConnection(databaseConnection.CONNECTION_STRING);

            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();
                int x = 0;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        x = reader.GetInt32(0);
                    }

                    if (x < 10)
                    {
                        labelEmployeeNumber.Text = "0" + x.ToString();
                    }
                    else
                    {
                        labelEmployeeNumber.Text = x.ToString();
                    }

                }
                connection.Close();
            }

            //Administrators 
            sql = "select count(*) from admnin";

            connection = new SqlConnection(databaseConnection.CONNECTION_STRING);
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();
                int x = 0;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        x = reader.GetInt32(0);
                    }
                    labelAdminNUmber.Text = x.ToString();
                }
                connection.Close();
            }
        }

        private void customise_design()
        {
            panelManageEmployees.Visible = false;
            panelSystemManagement.Visible = false;
        }

        private void hideSubMenu()
        {
            if(panelManageEmployees.Visible == true)
            {
                panelManageEmployees.Visible = false;
            }
            if (panelSystemManagement.Visible == true)
            {
                panelSystemManagement.Visible = false;
            }
        }

        private void showSubMenu(Panel sunbMenu)
        {
            if(sunbMenu.Visible == false) {
                hideSubMenu();
                sunbMenu.Visible = true;
            }
            else
            {
                sunbMenu.Visible = false;
            }
        }

   

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (panelManageEmployees.Visible)
            {
                panelManageEmployees.Hide();
            }
            else
            {
                panelManageEmployees.Show();

            }
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            buttonAddEmployee.BackColor = Color.FromArgb(32, 38, 71);
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            buttonAddEmployee.BackColor = Color.FromArgb(72, 75, 76);
        }

 /*       private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'admin_employeeDBDataSet.admnin' table. You can move, or remove it, as needed.
            this.admninTableAdapter.Fill(this.admin_employeeDBDataSet.admnin);
            // TODO: This line of code loads data into the 'employeeDBDataSet1.contactDetails' table. You can move, or remove it, as needed.
            this.contactDetailsTableAdapter.Fill(this.employeeDBDataSet1.contactDetails);
            // TODO: This line of code loads data into the 'employeeDBDataSet.employee' table. You can move, or remove it, as needed.
            try
            {
                this.employeeTableAdapter.Fill(this.employeeDBDataSet.employee);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }*/

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //panel_top.BackColor = Color.FromArgb(58, 6, 51);
            panel_group_name.BackColor = Color.FromArgb(192, 190, 190);
            buttonAddEmployee.BackColor = Color.FromArgb(192, 190, 190);
            buttonAddEmployee.ForeColor = Color.FromArgb(72, 75, 76);
           // tab_name.ForeColor = Color.FromArgb(58, 6, 63);


            //add_employee_panel.BackColor = Color.FromArgb(58, 6, 63);

            //add_employee_panel.BringToFront();

            tab_name.Text = "Add Employee";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //panel_top.BackColor = Color.FromArgb(136, 13, 148);
            panel_group_name.BackColor = Color.FromArgb(107, 7, 120);
            button2.BackColor = Color.FromArgb(107, 7, 120);
            tab_name.ForeColor = Color.FromArgb(107, 7, 120);

            // update_Employee_panel.BackColor = Color.FromArgb(107, 7, 120);

            //update_Employee_panel.BringToFront();

            tab_name.Text = "Update Employee";
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(72, 75, 76);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //panel_top.BackColor = Color.FromArgb(134, 7, 12);
            panel_group_name.BackColor = Color.FromArgb(99, 3, 5);
            button3.BackColor = Color.FromArgb(99, 3, 5);
            panel_delete.BringToFront();


            tab_name.ForeColor = Color.FromArgb(99, 3, 5);
            tab_name.Text = "Disable Employee";
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(72, 75, 76);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;

        private void panel_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel_top_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void female_radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void male_radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (panelManageEmployees.Visible)
            {
                panelManageEmployees.Hide();
            }
            else
            {
                panelManageEmployees.Show();

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSystemManagement);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelAddEmployee.BringToFront();
            tab_name.Text = "Add Employee";
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            panelDashbord.BringToFront();
            tab_name.Text = "Dash Board";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            panelUpdateEmployee.BringToFront();
            tab_name.Text = "Update Employee";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            tab_name.Text = "Diable Employee";
            panelDisableEmployee.BringToFront();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panelAdminManagement.BringToFront();
            tab_name.Text = "Admin Management";
            panelAdminManagement.BringToFront();
        }

        private void datagridview()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(72, 75, 76);
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.FromArgb(72, 75, 76);
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(36, 36, 36);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(72, 75, 76);
            dataGridView2.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView2.BackgroundColor = Color.FromArgb(72, 75, 76);

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(36, 36, 36);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);

            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(72, 75, 76);
            dataGridView3.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView3.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView3.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView3.BackgroundColor = Color.FromArgb(72, 75, 76);

            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(36, 36, 36);
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView3.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);
            dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);

            dataGridView4.BorderStyle = BorderStyle.None;
            dataGridView4.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(72, 75, 76);
            dataGridView4.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridView4.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView4.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView4.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView4.BackgroundColor = Color.FromArgb(72, 75, 76);

            dataGridView4.EnableHeadersVisualStyles = false;
            dataGridView4.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView4.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(36, 36, 36);
            dataGridView4.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView4.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);
            dataGridView4.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);

        }

        //Insert Employee Function
        private void button5_Click_1(object sender, EventArgs e)
        {
            String gender = "Male";
            if (male_radio.Checked) { gender = "M"; } else { gender = "F"; }            // set the genser

            String sql = "insert into employee ([firstName], [LastName], [dob], [id], [gender], [salary], [brachID], [Email], [PhoneNumber]," + //sql query for insertin
                " [Adress],[desegnation]) values(@first,@last,@dob,@id,@gender,@salary,@branch,@Email,@PhoneNumber,@Adress,'E')";

            if (jText_first_name.TextName.Length < 1 || jText_last_name.TextName.Length < 1 || jText_national_id.TextName.Length < 1 || jText_salary.TextName.Length < 1 || jText_branch_id.TextName.Length < 1 || jMaterialTextboxEmailAdress.TextName.Length < 1 || jMaterialTextboxAddress.TextName.Length < 1 || jMaterialTextboxPhoneNumber.TextName.Length < 1)//validating data inputted
            {
                MessageBox.Show("Please Feel in all fields, and verify all infomation entred is valid");    //message shown if input is invalid
            }
            else
            {
                SqlConnection connection = new SqlConnection(databaseConnection.CONNECTION_STRING);             //creating connection

                try
                {               
                    connection.Open();                                                              //opening connection
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        //initialising query parametres
                        cmd.Parameters.Add("@first", SqlDbType.NVarChar).Value = jText_first_name.TextName;
                        cmd.Parameters.Add("@last", SqlDbType.NVarChar).Value = jText_last_name.TextName;
                        cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = jText_national_id.TextName;
                        cmd.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;
                        cmd.Parameters.Add("@salary", SqlDbType.NVarChar).Value = jText_salary.TextName;
                        cmd.Parameters.Add("@branch", SqlDbType.NVarChar).Value = jText_branch_id.TextName;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = jMaterialTextboxEmailAdress.TextName;
                        cmd.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = jMaterialTextboxPhoneNumber.TextName;
                        cmd.Parameters.Add("@Adress", SqlDbType.NVarChar).Value = jMaterialTextboxAddress.TextName;
                        cmd.Parameters.Add("@dob", SqlDbType.NVarChar).Value = metroDateTimeDOB.Value;

                        int rowsAdded = cmd.ExecuteNonQuery();    //execute query
                        if (rowsAdded > 0) {
                            MessageBox.Show("Row inserted!!");      //check if insert ws sucessful
                        }
                        else
                            MessageBox.Show("No row inserted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.Message);  //catching ang execptions
                }
                connection.Close();                     //dispose connection
                datagridPopulate();                     //resfresh table ddata
            }
        }

        private void datagridPopulate()
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;

            using (SqlConnection connection = new SqlConnection(databaseConnection.CONNECTION_STRING)) 
            {
                var bindingSource = new BindingSource();
                string sql = "select * from employee";
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection))
                {
                    try
                    {
                        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                        DataTable table = new DataTable();
                        dataAdapter.Fill(table);
                        bindingSource.DataSource = table;

                        dataGridView1.ReadOnly = true;
                        dataGridView1.DataSource = bindingSource;

                        dataGridView2.ReadOnly = true;
                        dataGridView2.DataSource = bindingSource;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "ERROR Loading");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            populateAdminTable();
            populateBranchGrid();
            dashboardStats();
        }

        private void populateAdminTable()
        {
            using (SqlConnection connection = new SqlConnection(databaseConnection.CONNECTION_STRING))
            {
                var bindingSource = new BindingSource();
                string sql = "select * from admnin";

                using (SqlDataAdapter dataAdap = new SqlDataAdapter(sql, connection))
                {
                    connection.Open();
                    try
                    {
                        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdap);

                        DataTable table = new DataTable();
                        dataAdap.Fill(table);
                        bindingSource.DataSource = table;

                        dataGridView3.ReadOnly = true;
                        dataGridView3.DataSource = bindingSource;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "ERROR Loading");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

            }
        }

        private void populateBranchGrid()
        {
            using (SqlConnection connection = new SqlConnection(databaseConnection.CONNECTION_STRING))
            {
                var bindingSource = new BindingSource();
                string sql = "select brach.brachID as 'Branch ID',brach.branchName as 'Branch Name', brach.managerId as 'Manager ID',employee.firstName as 'Manager First Name', employee.LastName as 'Manager Last Name' from brach, employee where brach.managerId = employee.id; ";

                using (SqlDataAdapter dataAdap = new SqlDataAdapter(sql, connection))
                {
                    connection.Open();
                    try
                    {
                        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdap);

                        DataTable table = new DataTable();
                        dataAdap.Fill(table);
                        bindingSource.DataSource = table;

                        dataGridView4.ReadOnly = true;
                        dataGridView4.DataSource = bindingSource;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "ERROR Loading");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

            }
        }

        private void panel_delete_Paint(object sender, PaintEventArgs e)
        {

        }

        private void jMaterialTextbox14_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            String sql = "delete from employee where id = @id";      //queryy for deleting
            SqlConnection connection = new SqlConnection(databaseConnection.CONNECTION_STRING);  //initialise database connection

            try
            {
                connection.Open();              //open connection

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {

                    cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = jMaterialTextboxDeleteID.TextName;   // set query parametres

                    //verfy if process was compeleted
                    int rowsAdded = cmd.ExecuteNonQuery();
                    if (rowsAdded > 0)
                    {
                        MessageBox.Show("Employee Deleted!!");
                    }
                    else
                        MessageBox.Show("No row Deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);  // catch exceptions
            }
            connection.Close();    //dispose connection
            datagridPopulate();    //refresh displyed data
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            String sql = "select * from employee where id = @id";

            update_ID = jMaterialTextboxUpdateID.TextName;

            SqlConnection connection = new SqlConnection(databaseConnection.CONNECTION_STRING);

            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = jMaterialTextboxUpdateID.TextName;

                using (var reader = command.ExecuteReader())
                {                    
                    while (reader.Read()) {
                        label1FirstName.Text = reader.GetString(1);
                        label1LastName.Text = reader.GetString(2);
                        labelID.Text = reader.GetString(0);
                        labelEmail.Text = reader.GetString(7);
                        labelPhone.Text = reader.GetInt32(8).ToString();
                        labelBranch.Text = reader.GetString(6);
                        labelAddress.Text = reader.GetString(9);
                        label1Salary.Text = reader.GetSqlDouble(5).ToString();
                    }
                }
                connection.Close();
            }
        }

        private String update_option;


        private String update_ID;
        private String updateRow;
        private String update_Value;

        private void button11_Click(object sender, EventArgs e)
        {
            update_option = this.metroComboBoxUpdateOptionSelect.GetItemText(this.metroComboBoxUpdateOptionSelect.SelectedItem);
            update_Value = jMaterialTextboxUpdateValue.TextName;

            if (update_option == "First Name") { label1FirstName.Text = jMaterialTextboxUpdateValue.TextName; updateRow = "firstName"; }
            if (update_option == "Last Name") { label1LastName.Text = jMaterialTextboxUpdateValue.TextName; updateRow = "LastName"; }
            if (update_option == "Salary") { label1Salary.Text = jMaterialTextboxUpdateValue.TextName; updateRow = "salary"; }
            if (update_option == "ID") { labelID.Text = jMaterialTextboxUpdateValue.TextName; updateRow = "id"; }
            if (update_option == "Email") { labelEmail.Text = jMaterialTextboxUpdateValue.TextName; updateRow = "Email"; }
            if (update_option == "Phone") { labelPhone.Text = jMaterialTextboxUpdateValue.TextName; updateRow = "PhoneNumber"; }
            if (update_option == "Branch") { labelBranch.Text = jMaterialTextboxUpdateValue.TextName; updateRow = "brachID"; }
            if (update_option == "Adress") { labelAddress.Text = jMaterialTextboxUpdateValue.TextName; updateRow = "Adress"; }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            String sql = "update employee set "+updateRow+ " = @updateValue where id = @id";  //update query

            SqlConnection connection = new SqlConnection(databaseConnection.CONNECTION_STRING);  //initialising database connection

            try
            {
                using (var command = new SqlCommand(sql, connection))
                {
                    connection.Open();                                              //open conection

                    //Converting data to appropriate data types
                    if (updateRow == "salary") {
                        double sal = Double.Parse(update_Value);
                        command.Parameters.Add("@updateValue", SqlDbType.NVarChar).Value = sal;         
                    }
                    else if(updateRow == "PhoneNumber")
                    {
                        int phone = int.Parse(update_Value);
                        command.Parameters.Add("@updateValue", SqlDbType.NVarChar).Value = phone;
                    }
                    else { 
                        command.Parameters.Add("@updateValue", SqlDbType.NVarChar).Value = update_Value;
                    }

                    command.Parameters.Add("@id", SqlDbType.NVarChar).Value = update_ID;    //initialising query parameters

                    //verify if update was compeleted
                    int rowsAdded = command.ExecuteNonQuery();
                    if (rowsAdded > 0)
                    {
                        MessageBox.Show("Updated !!");
                    }
                    else
                        MessageBox.Show("Failed to update");

                    connection.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message); //catch and display exceptions
            }
            datagridPopulate();  // refresh data displayed
        }

        private void jMaterialTextboxUpdateValue_Load(object sender, EventArgs e)
        {

        }

        private void buttonBranchManagement_Click(object sender, EventArgs e)
        {
            panelSystemAdministrators.BringToFront();
        }

        private void jMaterialTextbox5_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            panelAddAdmin.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panelRemoveAdmin.BringToFront();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDBDataSet6.brach' table. You can move, or remove it, as needed.
            this.brachTableAdapter.Fill(this.employeeDBDataSet6.brach);
            // TODO: This line of code loads data into the 'employeeDBDataSet5.admnin' table. You can move, or remove it, as needed.
            this.admninTableAdapter.Fill(this.employeeDBDataSet5.admnin);
            // TODO: This line of code loads data into the 'employeeDBDataSet4.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeDBDataSet4.employee);

        }

        private void button18_Click(object sender, EventArgs e)
        {
            String sql = "insert into admnin ([firstName], [LastName], [password], [id]) values(@first,@last,@password,@id)"; //query to insert into database

            if (jMaterialTextboxAddAdminFirstname.TextName.Length < 1 || jMaterialTextboxjMaterialTextboxAddAdminLastName.TextName.Length < 1 || jMaterialTextboxjMaterialTextboxAddAdminID.TextName.Length < 1 || jMaterialTextboxAddAdminPassword.TextName.Length < 1 )//check for input
            {
                MessageBox.Show("Please Feel in all fields, and verify all infomation entred is valid"); //alert if incorrect input is entred
            }
            else
            {
                SqlConnection connection = new SqlConnection(databaseConnection.CONNECTION_STRING); //initialise connection

                try
                {

                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        //set quey parametres
                        cmd.Parameters.Add("@first", SqlDbType.NVarChar).Value = jMaterialTextboxAddAdminFirstname.TextName;
                        cmd.Parameters.Add("@last", SqlDbType.NVarChar).Value = jMaterialTextboxjMaterialTextboxAddAdminLastName.TextName;
                        cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = jMaterialTextboxjMaterialTextboxAddAdminID.TextName;
                        cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = jMaterialTextboxAddAdminPassword.TextName;

                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                        {
                            MessageBox.Show("Row inserted!!");
                        }
                        else
                            MessageBox.Show("No row inserted");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.Message);
                }
                connection.Close();  //dispose connection
                datagridPopulate();     // refresh data 

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            String sql = "select * from admnin where id = @id and password = @password";  //query to verify current user credentials

            update_ID = jMaterialTextboxUpdateID.TextName;

            SqlConnection connection = new SqlConnection(databaseConnection.CONNECTION_STRING);//initialise connection

            using (var command = new SqlCommand(sql, connection))
            {
                if (jMaterialTextboxRemoveAdminID.TextName.Length > 1 && jMaterialTextboxRemoveAdminPasswprd.TextName.Length > 1 && jMaterialTextboxRemoveAdminIdentityNumber.TextName.Length > 1)//validate input
                {
                    connection.Open();
                    command.Parameters.Add("@id", SqlDbType.NVarChar).Value = jMaterialTextboxRemoveAdminID.TextName; //initialise query parametres
                    command.Parameters.Add("@password", SqlDbType.NVarChar).Value = jMaterialTextboxRemoveAdminPasswprd.TextName;

                    using (var reader = command.ExecuteReader())
                    {
                        string x = "";
                        while (reader.Read())
                        {
                            x = reader.GetString(3);
                        }
                    if (x == jMaterialTextboxRemoveAdminPasswprd.TextName)// check if passwords match
                        {
                            connection.Close();
                            try
                            {
                                sql = "delete from admnin where id = @id"; //query to delete admin
                                connection.Open();

                                using (SqlCommand cmd = new SqlCommand(sql, connection))
                                {

                                    cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = jMaterialTextboxRemoveAdminIdentityNumber.TextName;//initialise query parametres

                                    int rowsAdded = cmd.ExecuteNonQuery();
                                    if (rowsAdded > 0)
                                    {
                                        MessageBox.Show("Administrator Deleted!!");
                                    }
                                    else
                                        MessageBox.Show("Process Failed ,Please verify entred credentials");

                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ERROR:" + ex.Message);
                            }

                            connection.Close();
                            datagridPopulate();
                        }
                    }
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Please Fill in all the fields");
                }
            }
        }

        private void buttonSalaries_Click(object sender, EventArgs e)
        {
            panelBranchManagement.BringToFront();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            String sql = "select * from employee where id = @id";  //sql query
            SqlConnection connection = new SqlConnection(databaseConnection.CONNECTION_STRING); //initialise connection string

            using (var command = new SqlCommand(sql, connection))
            {
                if (jMaterialTextboxSupervisorDelete.TextName.Length >= 1) //check if there was input in tectboc
                {
                    connection.Open();
                    command.Parameters.Add("@id", SqlDbType.NVarChar).Value = jMaterialTextboxSupervisorAdd.TextName; // set connection parameteres
                    using (var reader = command.ExecuteReader())
                    {
                        string x = "";
                        while (reader.Read())
                        {
                            x = reader.GetString(0);        //assign result to a string
                        }
                        if (x == jMaterialTextboxSupervisorAdd.TextName)  //compare DB results with user input
                        {
                            connection.Close();
                            try
                            {
                                sql = "update employee set desegnation = 'S' where id = @id";  // sql to update employee
                                connection.Open();

                                using (SqlCommand cmd = new SqlCommand(sql, connection))
                                {
                                    cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = jMaterialTextboxSupervisorAdd.TextName; //set parameters

                                    //check if process compeleted
                                    int rowsAdded = cmd.ExecuteNonQuery();
                                    if (rowsAdded > 0)
                                    {
                                        MessageBox.Show("Employee Updated!!"); // alerrt if process compeleted
                                    }
                                    else
                                        MessageBox.Show("Process Failed ,Please verify entred credentials");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ERROR:" + ex.Message); // catch exeptions
                            }
                            connection.Close();     // dispose conection
                            datagridPopulate();     // refresh display data
                        }
                    }
                    connection.Close();     //Dispose connection
                }
                else
                {
                    MessageBox.Show("Please Fill in all the fields");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String sql = "select * from employee where id = @id";     //sql query


            SqlConnection connection = new SqlConnection(databaseConnection.CONNECTION_STRING);  //initialise connection string

            using (var command = new SqlCommand(sql, connection))
            {
                if (jMaterialTextboxSupervisorDelete.TextName.Length >= 1)    //check if there was input in tectbo
                {
                    connection.Open();
                    command.Parameters.Add("@id", SqlDbType.NVarChar).Value = jMaterialTextboxSupervisorDelete.TextName;   // set connection parameteres

                    using (var reader = command.ExecuteReader())
                    {
                        string x = "";
                        while (reader.Read())
                        {
                            x = reader.GetString(0);           //assign result to a string
                        }
                        if (x == jMaterialTextboxSupervisorDelete.TextName)    //compare DB results with user input
                        {
                            connection.Close();
                            try
                            {
                                sql = "update employee set desegnation = 'E' where id = @id";  // sql to update employee
                                connection.Open();

                                using (SqlCommand cmd = new SqlCommand(sql, connection))
                                {

                                    cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = jMaterialTextboxSupervisorDelete.TextName; //set parameters

                                    //check if process compeleted
                                    int rowsAdded = cmd.ExecuteNonQuery();
                                    if (rowsAdded > 0)
                                    {
                                        MessageBox.Show("Employee Updated!!");   // alerrt if process compeleted
                                    }
                                    else
                                        MessageBox.Show("Process Failed ,Please verify entred credentials");

                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ERROR:" + ex.Message);   // catch exeptions
                            }

                            connection.Close();     // dispose conection
                            datagridPopulate();     // refresh display data
                        }
                    }
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Please Fill in all the fields");
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            panelAddBranch.BringToFront();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            String sql = "insert into brach ([brachID], [branchName], [managerId]) values(@managerId,@brachID,@branchName)"; //query to insert into database

            if (jMaterialTextboxBranchManagerId.TextName.Length < 1 || jMaterialTextboxBranchID.TextName.Length < 1 || jMaterialTextboxBrachName.TextName.Length < 1 )//check for input
            {
                MessageBox.Show("Please Feel in all fields, and verify all infomation entred is valid"); //alert if incorrect input is entred
            }
            else
            {
                SqlConnection connection = new SqlConnection(databaseConnection.CONNECTION_STRING); //initialise connection

                try
                {

                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        //set quey parametres
                        cmd.Parameters.Add("@managerId", SqlDbType.NVarChar).Value = jMaterialTextboxBranchManagerId.TextName;
                        cmd.Parameters.Add("@brachID", SqlDbType.NVarChar).Value = jMaterialTextboxBranchID.TextName;
                        cmd.Parameters.Add("@branchName", SqlDbType.NVarChar).Value = jMaterialTextboxBrachName.TextName;

                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                        {
                            MessageBox.Show("Row inserted!!");
                        }
                        else
                            MessageBox.Show("No row inserted");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.Message);
                }
                connection.Close();  //dispose connection
                populateBranchGrid();     // refresh data 

            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            String sql = "select * from brach where brachID = @id";  //sql query
            SqlConnection connection = new SqlConnection(databaseConnection.CONNECTION_STRING); //initialise connection string

            using (var command = new SqlCommand(sql, connection))
            {
                if (jMaterialTextboxSupervisorDelete.TextName.Length >= 1) //check if there was input in tectboc
                {
                    connection.Open();
                    command.Parameters.Add("@id", SqlDbType.NVarChar).Value = jMaterialTextboxREmovebranchID.TextName; // set connection parameteres
                    using (var reader = command.ExecuteReader())
                    {
                        string x = "";
                        while (reader.Read())
                        {
                            x = reader.GetString(0);        //assign result to a string
                        }
                        if (x == jMaterialTextboxREmovebranchID.TextName)  //compare DB results with user input
                        {
                            connection.Close();
                            try
                            {
                                sql = "delete from brach where brachID = @id";  // sql to update employee
                                connection.Open();

                                using (SqlCommand cmd = new SqlCommand(sql, connection))
                                {
                                    cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = jMaterialTextboxREmovebranchID.TextName; //set parameters

                                    //check if process compeleted
                                    int rowsAdded = cmd.ExecuteNonQuery();
                                    if (rowsAdded > 0)
                                    {
                                        MessageBox.Show("Employee Updated!!"); // alerrt if process compeleted
                                    }
                                    else
                                        MessageBox.Show("Process Failed ,Please verify entred credentials");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ERROR:" + ex.Message); // catch exeptions
                            }
                            connection.Close();     // dispose conection
                            datagridPopulate();     // refresh display data
                        }
                    }
                    connection.Close();     //Dispose connection
                }
                else
                {
                    MessageBox.Show("Please Fill in all the fields");
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            panelFormRemoveBranch.BringToFront();
        }
    }
}
