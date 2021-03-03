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

        public ContextDB context;
        public Form1()
        {
            InitializeComponent();
            labelConnectionStatus.Text = "closed";
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GoogleDrive\STEP\ADO\Class_work\ADO_Basics\ADO1.mdf;Integrated Security=True");
            command = new SqlCommand();
            command.Connection = connection;
            //Buttons_activate_or_deactivate(false);
            
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

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                labelConnectionStatus.Text = "Open OK";
                command.Connection = connection;
            }
            catch (Exception ex)
            {
                labelConnectionStatus.Text = ex.Message;
                return;
            }
            context = new ContextDB();
            context.Connection = connection;
        }

        private void buttonUserInsert_Click(object sender, EventArgs e)
        {
            //Получаем имя
            var nameForm = new NameForm();
            nameForm.ShowDialog();
            if (nameForm.Result)
            {
                //Создаём объект ORM
                User u = new User() { Name = nameForm.UserName };

                //Добавляем через метод контекста
                try
                {
                    context.AddUser(u);
                    MessageBox.Show("Insert OK");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonUserSelect_Click(object sender, EventArgs e)
        {
            try
            {
                new ResultForm()
                {
                    Users = context.GetUsers(),
                    workMode = WorkMode.ReadUser
                }
                .ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUserDelete_Click(object sender, EventArgs e)
        {
            try
            {
                new ResultForm()
                {
                    Users = context.GetUsers(),
                    workMode = WorkMode.DeleteUser
                }
                .ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUserUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                new ResultForm()
                {
                    Users = context.GetUsers(),
                    workMode = WorkMode.UpdateUser
                }
                .ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonProductInsert_Click(object sender, EventArgs e)
        {
            //Получаем имя
            var ProductForm = new ProductForm();
            ProductForm.ShowDialog();
            if (ProductForm.Result)
            {
                //Создаём объект ORM
                Product p = new Product() { Name = ProductForm.ProductName, Price = ProductForm.ProductPrice };

                //Добавляем через метод контекста
                try
                {
                    context.AddProduct(p);
                    MessageBox.Show("Insert OK");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonProductSelect_Click(object sender, EventArgs e)
        {
            try
            {
                new ResultForm()
                {
                    Products = context.GetProducts(),
                    workMode = WorkMode.ReadProduct
                }
                .ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonProductUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                new ResultForm()
                {
                    Products = context.GetProducts(),
                    workMode = WorkMode.UpdateProduct
                }
                .ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonProductDelete_Click(object sender, EventArgs e)
        {
            try
            {
                new ResultForm()
                {
                    Products = context.GetProducts(),
                    workMode = WorkMode.DeleteProduct
                }
                .ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

//Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GoogleDrive\STEP\ADO\Class_work\ADO_Basics\ADO1.mdf;Integrated Security=True
