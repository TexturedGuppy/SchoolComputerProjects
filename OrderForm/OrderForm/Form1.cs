using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "" && txtCity.Text != "" && txtState.Text != "")
            {
                lstCustomers.Items.Add(new Customer());
                Reset();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reset()
        {
            txtName.Text = "";
            txtCity.Text = "";
            txtState.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtState_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            lblError.Text = "Invalid Input";
            lblError.Visible = true;
        }
        private void txtState_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
