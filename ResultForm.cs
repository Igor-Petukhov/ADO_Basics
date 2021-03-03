using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Basics
{
    public partial class ResultForm : Form
    {
        public List<User> Users { get; set; }
        public List<Product> Products { get; set; }
        public WorkMode workMode;

        public ResultForm()
        {
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            if ((workMode == WorkMode.CreateUser) || (workMode == WorkMode.DeleteUser) || (workMode == WorkMode.ReadUser) || (workMode == WorkMode.UpdateUser))
                foreach (User u in Users)
                {
                    listBox1.Items.Add(u);
                }
            else if ((workMode == WorkMode.CreateProduct) || (workMode == WorkMode.DeleteProduct) || (workMode == WorkMode.ReadProduct) || (workMode == WorkMode.UpdateProduct))
                foreach (Product p in Products)
                {
                    listBox1.Items.Add(p);
                }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            switch (workMode)
            {
                case WorkMode.CreateUser:
                    break;
                case WorkMode.ReadUser:
                    break;
                case WorkMode.UpdateUser:
                    UpdateUser();
                    break;
                case WorkMode.DeleteUser:
                    DeleteUser();
                    break;
                case WorkMode.CreateProduct:
                    break;
                case WorkMode.ReadProduct:
                    break;
                case WorkMode.UpdateProduct:
                    UpdateProduct();
                    break;
                case WorkMode.DeleteProduct:
                    DeleteProduct();
                    break;
                default:
                    break;
            }
        }

        void UpdateUser()
        {
            var selectedUser = listBox1.SelectedItem as User;
            if (selectedUser == null)
            {
                MessageBox.Show("Select an User");
            }
            else
            {
                var nf = new NameForm()
                {
                    UserName = selectedUser.Name,
                    Text = "New name for user"
                };
                nf.ShowDialog();
                if (nf.Result)
                {
                    if (DialogResult.Yes ==
                    MessageBox.Show(
                        $"Change user from {selectedUser.Name} to {nf.UserName} ?",
                        selectedUser.ToString(),
                        MessageBoxButtons.YesNo))
                    {
                        try
                        {
                            selectedUser.Name = nf.UserName;
                            (Owner as Form1).context.UpdateUser(selectedUser);
                            int index = listBox1.SelectedIndex;
                            listBox1.Items.Remove(selectedUser);
                            
                            listBox1.Items.Insert(index, selectedUser);
                            listBox1.SelectedIndex = index;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }

            }

        }

        void DeleteUser()
        {
            var selectedUser = listBox1.SelectedItem as User;
            if (selectedUser == null)
            {
                MessageBox.Show("Select an User");
            }
            else
            {
                if (DialogResult.Yes ==
                    MessageBox.Show(
                        "Delete?",
                        selectedUser.ToString(),
                        MessageBoxButtons.YesNo))
                {
                    try
                    {
                        (Owner as Form1).context.DeleteUser(selectedUser);
                        listBox1.Items.Remove(selectedUser);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        void UpdateProduct()
        {
            var selectedProduct = listBox1.SelectedItem as Product;
            if (selectedProduct == null)
            {
                MessageBox.Show("Select a Product");
            }
            else
            {
                var pf = new ProductForm()
                {
                    ProductName = selectedProduct.Name,
                    ProductPrice = selectedProduct.Price,
                    Text = "New product"
                };
                pf.ShowDialog();
                if (pf.Result)
                {
                    if (DialogResult.Yes ==
                    MessageBox.Show(
                        $"Change product from {selectedProduct.Name} - {selectedProduct.Price} to {pf.ProductName} - {pf.ProductPrice} ?",
                        selectedProduct.ToString(),
                        MessageBoxButtons.YesNo))
                    {
                        try
                        {
                            selectedProduct.Name = pf.ProductName;
                            selectedProduct.Price = pf.ProductPrice;
                            (Owner as Form1).context.UpdateProduct(selectedProduct);
                            int index = listBox1.SelectedIndex;
                            listBox1.Items.Remove(selectedProduct);

                            listBox1.Items.Insert(index, selectedProduct);
                            listBox1.SelectedIndex = index;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
        }

        void DeleteProduct()
        {
            var selectedProduct = listBox1.SelectedItem as Product;
            if (selectedProduct == null)
            {
                MessageBox.Show("Select a Product");
            }
            else
            {
                if (DialogResult.Yes ==
                    MessageBox.Show(
                        "Delete?",
                        selectedProduct.ToString(),
                        MessageBoxButtons.YesNo))
                {
                    try
                    {
                        (Owner as Form1).context.DeleteProduct(selectedProduct);
                        listBox1.Items.Remove(selectedProduct);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
