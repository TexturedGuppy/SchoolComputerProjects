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
            if(txtName.Text != "" 
                && txtCity.Text != "" 
                && txtState.Text != ""
                && (radDonNo.Checked||radDonYes.Checked)
                && (radSigNo.Checked || radSigYes.Checked))
            {
                lstCustomers.Items.Add(new Customer(txtName.Text));
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

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer c = (Customer)lstCustomers.SelectedItem;
            txtName.Text = c.Name;

            lstOrders.Items.Clear();

            foreach(Order o in c.orders)
            {
                lstOrders.Items.Add(o);
            }
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tipToolTip.SetToolTip(radDonYes, "Add a Donation Today!");
            //errorProvider1.SetError(txtCity, "That's not a real city!");

        }

        private void chkOvernight_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            if (txtCity.Text.Length < 2)
                errorProvider1.SetError(txtCity, "Name of city should be more than 1 character!");
            else
                errorProvider1.Clear();
        }

        private void txtCity_Leave(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
           
            if (lstCustomers.SelectedItem != null)
            {
                Customer temp = ((Customer)lstCustomers.SelectedItem);
                temp.orders.Add(new Order());
                Order o = temp.orders[temp.orders.Count - 1];
                o.date = calDatePicker.SelectionStart;
                lstOrders.Items.Add(temp.orders[temp.orders.Count - 1]);
            }


        }
    }
}
