using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2002807_Maeda_XtremeCinema12
{
    public class Rental
    {
        string format = "DVD";

        public string title { get; set; }
        public bool bluray { get; set; }
        public bool dvd { get; set; }
        public bool newRelease { get; set; }

        public Rental(string t, bool isbluray, bool nr)
        {
            title = t;
            if (isbluray == true)
            {
                bluray = true;
                dvd = false;
                format = "Blu-Ray";
            }
            else
            {
                dvd = true;
                bluray = false;
            }
            newRelease = nr;

        }

        public override string ToString()
        {
            return "Title: " + title + Environment.NewLine +
                "Format: " + format + Environment.NewLine +
                "Is New Release: " + newRelease + Environment.NewLine;
        }

    }
}
