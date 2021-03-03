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
    public partial class ProductForm : Form
    {
        public String ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public bool Result { get; private set; }
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            textBoxName.Text = ProductName;
            textBoxPrice.Text = ProductPrice.ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Result = false;
            Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Equals(String.Empty) || textBoxPrice.Text.Equals(String.Empty))
            {
                MessageBox.Show("Empty name or price not allowed");
                return;
            }

            ProductName = textBoxName.Text;
            ProductPrice = decimal.Parse(textBoxPrice.Text);
            Result = true;
            Close();
        }
    }
}
