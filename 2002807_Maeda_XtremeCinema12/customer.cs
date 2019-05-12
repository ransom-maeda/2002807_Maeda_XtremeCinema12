using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2002807_Maeda_XtremeCinema12
{
    public class Customer
    {
        public bool isMember { get; set; }

        public Customer(bool isMem)
        {
            isMember = isMem;
        }
    }
}