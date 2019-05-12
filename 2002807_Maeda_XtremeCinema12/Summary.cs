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
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
            amountOutput.ReadOnly = true;
            sumOutput.ReadOnly = true;
        }


    }
}
