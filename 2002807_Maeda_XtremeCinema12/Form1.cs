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

        public Form1()
        {
            InitializeComponent();
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

        private void clearForNextItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //clears textbox and buttons
            titleInput.Clear();
            checkMember.Checked = false;
            checkNew.Checked = false;
            buttonBD.Checked = false;
            buttonDVD.Checked = false;
        }

        private void selectFont()
        {
            fontChange.ShowDialog();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculate();
        }

        public void calculate()
        {
            if (titleInput.Text == "" || (buttonBD.Checked == false && buttonDVD.Checked == false))
            {
                MessageBox.Show("Please enter a valid input", "Error");
            }
            else
            {

            }

        }
    }
}
