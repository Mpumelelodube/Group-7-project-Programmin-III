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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //This is the login Function
        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(databaseConnection.CONNECTION_STRING);//Declaration and initialisation of database connection
            connection.Open();                                                                 //open The connection

            if(connection.State == System.Data.ConnectionState.Open)                    //Conditional statement to check if the connection is open before querying
            {
                // declaration of variebles to store query results
                String id_num = "";
                string pass = "";

                String sql = "select * from admnin where id = @id and password = @password";  // Query to be exevuted
                SqlCommand cmd = new SqlCommand(sql, connection);


                //setting up query parameters with the values entered by user in the form
                cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id_textbox.TextName;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = password_text_box.TextName;

                using (var reader = cmd.ExecuteReader())
                {
                    //loop to read query results
                    while (reader.Read())
                    {
                        id_num = reader.GetString(0);
                        pass = reader.GetString(3);
                    }

                    //conditional statement to compare results from database and those entred by user
                    if (id_num == id_textbox.TextName && pass == password_text_box.TextName)
                    {
                        Form2 Check = new Form2();      // initialising main program form
                        Check.Show();                   // displaying the main program form
                        Hide();                         // Hiding the current form
                    }
                    else
                    {
                        MessageBox.Show("Error logging in");        //error message
                    }
                }
            }
            connection.Close(); //disposing of connection after use
        }


        //Function to exit the program
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
