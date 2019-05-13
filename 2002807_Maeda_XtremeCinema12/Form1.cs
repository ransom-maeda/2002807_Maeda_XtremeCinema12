using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2002807_Maeda_XtremeCinema12
{
    public partial class Form1 : Form
    {

        double total = 0;
        RentalOrder rentalOrder = null;
        Customer customer = null;

        public Form1()
        {
            InitializeComponent();
            totalOutput.ReadOnly = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info box = new info();
            box.ShowDialog();
        }

        private void eXitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectColor();
            this.BackColor = colorChange.Color;
        }

        private void selectColor()
        {
            colorChange.ShowDialog();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //receives font selection and outputs it
            selectFont();
            titleInput.Font = fontChange.Font;
            buttonBD.Font = fontChange.Font;
            buttonDVD.Font = fontChange.Font;
            boxInfo.Font = fontChange.Font;
        }

        private void resetForm(bool newOrder)
        {
            //clears textbox and buttons
            titleInput.Clear();
            checkMember.Checked = false;
            checkNew.Checked = false;
            buttonBD.Checked = false;
            buttonDVD.Checked = false;

            if (newOrder == true)
            {
                customer = null;
                rentalOrder = null;
                checkMember.Enabled = true;
                totalOutput.Clear();
            }
        }

        private void clearForNextItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetForm(false);
        }

        private void selectFont()
        {
            fontChange.ShowDialog();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (titleInput.Text == "" || (buttonBD.Checked == false && buttonDVD.Checked == false))
            {
                MessageBox.Show("Please enter a valid input", "Error");
            }
            else
            {
                //Is customer created yet?
                if(customer == null)
                {
                    customer = new Customer(checkMember.Checked);
                    rentalOrder = new RentalOrder(customer);
                }

                //Create rental item
                string title = titleInput.Text;
                bool isBD = false;
                bool newRelease = false;
                if(checkNew.Checked == true)
                {
                    newRelease = true;
                }
                if (buttonBD.Checked == true)
                {
                    isBD = true;
                }
                Rental rental = new Rental(title, isBD, newRelease);

                //Pass rental item to calculate function
                rentalOrder.calculate(rental);
                checkMember.Enabled = false;
                totalOutput.Text = rentalOrder.subTotal.ToString("C");
            }

        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Summary summary = new Summary();
            summary.ShowDialog();
        }

        private void orderCompleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Is your order complete?";
            DialogResult response = MessageBox.Show(message, "Order Complete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(response == DialogResult.Yes)
            {
                // Update rental summary
                RentalSummary.customerAmount += 1;
                RentalSummary.rentalSum += rentalOrder.subTotal;

                // Reset form
                resetForm(true);
            }
        }
    }
}
