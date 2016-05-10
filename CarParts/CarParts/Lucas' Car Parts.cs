//Lucas Hauf
//Pos 409
//12/22/2015
//this program was made to allow the user to calcualte thier car part based on the constructor they choose to use 



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParts
{
    public partial class frmCarParts : Form
    {
        

        public frmCarParts()
        {
            InitializeComponent();
  
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CalcDefault()
        {

            if (rdbCarParts.Checked == true)
            {
                if (txtPart.Text == "")
                {
                    MessageBox.Show("Please enter a name for your part");
                    txtPart.Focus();
                    txtPart.SelectAll();
                    return;
                }
                else if (txtPrice.Text == "0.00")
                {
                    MessageBox.Show("Please enter a price");
                    txtPrice.Focus();
                    txtPrice.SelectAll();
                    return;
                }
                
                else if (txtQty.Text == "0")
                {
                    MessageBox.Show("Please enter a Qty");
                    txtQty.Focus();
                    txtQty.SelectAll();
                    return;
                }
               
                CarPartsMethods Parts = new CarPartsMethods();
                Parts.setParts(this.txtPart.Text);
                try
                {
                    Parts.setQyt(int.Parse(txtQty.Text));
                }
                catch
                {
                    MessageBox.Show("Invalid format in Qty Field");
                    txtQty.Focus();
                    txtQty.SelectAll();
                    return;
                }
                try
                {
                    Parts.setPrice(double.Parse(txtPrice.Text));

                }
                catch
                {

                    MessageBox.Show("Invalid format in Price Field");
                    txtPrice.Focus();
                    txtPrice.SelectAll();
                    return;
                }



                lblTotalDollars.Text = txtPart.Text + ": " + Parts.TotalWithTax().ToString("C");
            }
            else if (rdbAdditional.Checked == true)
            {
               
                
                AdditionalParts Additional = new AdditionalParts();

                if (txtPart.Text == "")
                {
                    MessageBox.Show("Please enter a name for your part");
                    txtPart.Focus();
                    txtPart.SelectAll();
                    return;
                }
                else if (txtPrice.Text == "0.00")
                {
                    MessageBox.Show("Please enter a price");
                    txtPrice.Focus();
                    txtPrice.SelectAll();
                    return;
                }
                else if (txtQty.Text == "0")
                {
                    MessageBox.Show("Please enter a Qty");
                    txtQty.Focus();
                    txtQty.SelectAll();
                    return;
                }

                Additional.setParts(this.txtPart.Text);
                try
                {
                    Additional.setQyt(int.Parse(txtQty.Text));
                }
                catch
                {
                    MessageBox.Show("Invalid format in Qty Field");
                    txtQty.Focus();
                    txtQty.SelectAll();
                    return;
                }
                try
                {
                    Additional.setPrice(double.Parse(txtPrice.Text));

                }
                catch
                {

                    MessageBox.Show("Invalid format in Price Field");
                    txtPrice.Focus();
                    txtPrice.SelectAll();
                    return;
                }
                try
                {
                    Additional.setYear(int.Parse(txtYear.Text));
                }
                catch
                {
                    MessageBox.Show("Invalid format in year Field");
                    txtYear.Focus();
                    txtYear.SelectAll();
                    return;
                }
                lblTotalDollars.Text = txtYear.Text + ": " + txtModel.Text + ": " + txtPart.Text + ": " + Additional.TotalWithTax().ToString("C");
            }
            else
            {
                MessageBox.Show("Please click a button");
            }

        }
       


        private void CalcOverloaded()
        {
            if (rdbCarParts.Checked == true)
            {
                if (txtPart.Text == "")
                {
                    MessageBox.Show("Please enter a name for your part");
                    txtPart.Focus();
                    txtPart.SelectAll();
                    return;
                }
                else if (txtPrice.Text == "0.00")
                {
                    MessageBox.Show("Please enter a price");
                    txtPrice.Focus();
                    txtPrice.SelectAll();
                    return;
                }
                else if (txtQty.Text == "0")
                {
                    MessageBox.Show("Please enter a Qty");
                    txtQty.Focus();
                    txtQty.SelectAll();
                    return;
                }
                try
                {
                    double Price = double.Parse(txtPrice.Text);
                }
                catch
                {

                    MessageBox.Show("Invalid format in Price Field");
                    txtPrice.Focus();
                    txtPrice.SelectAll();
                    return;
                }

                try
                {
                    int Qyt = int.Parse(this.txtQty.Text);
                }
                catch
                {
                    MessageBox.Show("Invalid format in Qty Field");
                    txtQty.Focus();
                    txtQty.SelectAll();
                    return;
                }


                CarPartsMethods Parts = new CarPartsMethods(this.txtPart.Text, int.Parse(this.txtQty.Text), double.Parse(this.txtPrice.Text));

                lblTotalDollars.Text = txtPart.Text + ": " + Parts.TotalWithTax().ToString("C");
            }
            else if (rdbAdditional.Checked == true)
            {
                if (txtPart.Text == "")
                {
                    MessageBox.Show("Please enter a name for your part");
                    txtPart.Focus();
                    txtPart.SelectAll();
                    return;
                }
                else if (txtPrice.Text == "0.00")
                {
                    MessageBox.Show("Please enter a price");
                    txtPrice.Focus();
                    txtPrice.SelectAll();
                    return;
                }
                else if (txtQty.Text == "0")
                {
                    MessageBox.Show("Please enter a Qty");
                    txtQty.Focus();
                    txtQty.SelectAll();
                    return;
                }
                else if (txtModel.Text == "")
                {
                    MessageBox.Show("Please enter a Model");
                    txtModel.Focus();
                    txtModel.SelectAll();
                    return;
                }
                try
                {
                    double Price = double.Parse(txtPrice.Text);
                }
                catch
                {

                    MessageBox.Show("Invalid format in Price Field");
                    txtPrice.Focus();
                    txtPrice.SelectAll();
                    return;
                }

                try
                {
                    int Qyt = int.Parse(this.txtQty.Text);
                }
                catch
                {
                    MessageBox.Show("Invalid format in Qty Field");
                    txtQty.Focus();
                    txtQty.SelectAll();
                    return;
                }
                try
                {
                    int Year = (int.Parse(txtYear.Text));
                }
                catch
                {
                    MessageBox.Show("Invalid format in year Field");
                    txtYear.Focus();
                    txtYear.SelectAll();
                    return;
                }

                AdditionalParts Additional = new AdditionalParts(this.txtPart.Text, int.Parse(this.txtQty.Text), double.Parse(this.txtPrice.Text), txtModel.Text, int.Parse(txtYear.Text));

                lblTotalDollars.Text = txtYear.Text + ": " + txtModel.Text + ": " + txtPart.Text + ": " + Additional.TotalWithTax().ToString("C");
            }
            else
            {
                MessageBox.Show("Please click a button");
            }
        }

        
        private void btnCalculateOverloaded_Click(object sender, EventArgs e)
        {
           
                CalcOverloaded();
        
        }

        private void btnCalculateDefault_Click(object sender, EventArgs e)
        {
            CalcDefault();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPart.Text = "";
            lblTotalDollars.Text = "";
            txtPrice.Text = "0.00";
            txtQty.Text = "0";
            txtModel.Text = "";
            txtModel.Enabled = false;
           
            txtYear.Enabled = false;
            
        }

        private void rdbAdditional_CheckedChanged(object sender, EventArgs e)
        {
           
            txtModel.Enabled = true;
           
            txtYear.Enabled = true;
        }

        private void rdbCarParts_CheckedChanged(object sender, EventArgs e)
        {
           
            txtModel.Enabled = false;
           
            txtYear.Enabled = false;
            lblTotalDollars.Text = "";
            txtModel.Text = "";
            txtYear.Text = "";
        }
       
    }
}
