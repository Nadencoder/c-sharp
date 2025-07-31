using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_user_clicks_the_Exit_button
{
    public partial class Form1 : Form
    {
        private EventHandler btnExit_click;

        public Form1()
        {
            InitializeComponent();
            btnExit.Click += btnExit_click;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * This is method calculate the total 
             * For an invoice depending on a discont that's based on the subtotal
            */

            //get the subtotal amount from the Subtotal txt box
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);

            //Set the discont varirable based  on the value of the subtotal variable
            decimal discontPct = 0m;
            if (subtotal >= 500)
            {
                discontPct = .2m;
            }
            else if (subtotal >= 250 && subtotal < 500)
            {
                discontPct = .15m;
            }
            else if (subtotal >= 100 && subtotal < 250)
            {
                discontPct = .1m;
            }

            //Calculate and assign the value for the discont Amt and invoiceTotal variables
            decimal discountAmt = subtotal * discontPct;
            decimal invoiceTotal = subtotal - discountAmt;

            //Fotmat the values and display them in thier text boxes
            txtDiscontPct.Text = discontPct.ToString("p1");//percent format with 1 decimal place
            txtDiscontAmt.Text = invoiceTotal.ToString("c");//currency format
            txtTotal.Text = invoiceTotal.ToString("c"); 

            //move the focus to the subtotal text box

            txtSubtotal.Focus();
            
        }
    }
}
