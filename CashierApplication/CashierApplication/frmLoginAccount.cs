using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }
        static double price, discount, quantity;



        private void Login_Click(object sender, EventArgs e)
        {
           // if (Login.Text.Equals("Jessie") && pass.Text.Equals("Pogi"))
           // {
                frmPurchasedDiscountedItem frmp = new frmPurchasedDiscountedItem();
                frmp.Show();
                this.Hide();
            //}
           // else
           // {
                MessageBox.Show("Invalid Inputs");
           // }
        }
    }
}
