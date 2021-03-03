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
    public partial class NameForm : Form
    {
        public String UserName { get; set; }
        public bool Result { get; private set; }
        
        public NameForm()
        {
            InitializeComponent();
        }

        private void NameForm_Load(object sender, EventArgs e)
        {
            textBoxName.Focus();
            textBoxName.Text = UserName;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Equals(String.Empty))
            {
                MessageBox.Show("Empty name not allowed");
                return;
            }
            UserName = textBoxName.Text;
            Result = true;
            Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Result = false;
            Close();
        }
    }
}
