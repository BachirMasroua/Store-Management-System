using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Management_System.Classes
{
    class OExceptions
    {
        public void checkEmptyString(Form frm, string s, string label)
        {
            if (s == "")
            {
                MessageBox.Show("You must add a " + label);
                frm.Close();
            }
        }

        public void checkPositiveNumber(Form frm,double d, string label)
        {
            if(d < 0)
            {
                MessageBox.Show(label + " must be positive!");
                frm.Close();
            }
        }

        public void checkPrices(Form frm, double initial, double selling)
        {
            if (initial > selling)
            {
                MessageBox.Show("Initial price must be less than Selling price!!");
                frm.Close();
            }
        }
    }
}
