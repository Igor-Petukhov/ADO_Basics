using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace ADO_Basics
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        public Form1()
        {
            InitializeComponent();
            labelConnectionStatus.Text = "closed";
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GoogleDrive\STEP\ADO\Class_work\ADO_Basics\ADO1.mdf;Integrated Security=True");
            command = new SqlCommand();
            command.Connection = connection;
            Buttons_activate_or_deactivate(false);
            
        }
        

        private void buttonUsersCreate_Click(object sender, EventArgs e)
        {
            command.CommandText = @"CREATE TABLE Users(
	                                Id INT PRIMARY KEY IDENTITY(1,1),
	                                [Name] NVARCHAR(64) NOT NULL
	                                )";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("CREATE OK");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUsersDrop_Click(object sender, EventArgs e)
        {
            command.CommandText = @"DROP TABLE Users";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("DROP OK");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Products_create_Click(object sender, EventArgs e)
        {
            command.CommandText = @"CREATE TABLE Products(
	                                Id INT PRIMARY KEY IDENTITY(1,1),
	                                [Name] NVARCHAR(64) NOT NULL,
                                    price MONEY NOT NULL
	                                )";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("CREATE OK");
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Products_Drop_Click(object sender, EventArgs e)
        {
            command.CommandText = @"DROP TABLE Products";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("DROP OK");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Sales_Create_Click(object sender, EventArgs e)
        {
            command.CommandText = @"CREATE TABLE Sales(
	                                Id INT PRIMARY KEY IDENTITY(1,1),
	                                id_user INT NOT NULL,
                                    FOREIGN KEY (id_user) REFERENCES Users(Id),
	                                id_product INT NOT NULL,
                                    FOREIGN KEY (id_product) REFERENCES Products(Id),
	                                moment DATE NOT NULL
	                                )";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("CREATE OK");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Sales_Drop_Click(object sender, EventArgs e)
        {
            command.CommandText = @"DROP TABLE Sales";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("DROP OK");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                labelConnectionStatus.Text = "Open OK";
                Buttons_activate_or_deactivate(true);
            }
            catch (Exception ex)
            {
                labelConnectionStatus.Text = ex.Message;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                labelConnectionStatus.Text = "closed";
                Buttons_activate_or_deactivate(false);
            }
            catch (Exception ex)
            {
                labelConnectionStatus.Text = ex.Message;
            }
        }

        private void Buttons_activate_or_deactivate(bool activated_deactivated)
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is Button)
                    control.Enabled = activated_deactivated;
            }
            foreach (Control control in groupBox2.Controls)
            {
                if (control is Button)
                    control.Enabled = activated_deactivated;
            }
            foreach (Control control in groupBox3.Controls)
            {
                if (control is Button)
                    control.Enabled = activated_deactivated;
            }
        }
    }
}

//Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GoogleDrive\STEP\ADO\Class_work\ADO_Basics\ADO1.mdf;Integrated Security=True
