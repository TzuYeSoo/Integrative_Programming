using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }
        


        private void Compute_Sal_Click(object sender, EventArgs e)
        {
            PartTimeEmployee ptE = new PartTimeEmployee(fname.Text, Lname.Text, Dep.Text, JT.Text);
            ptE.computeSalary(Convert.ToInt32(HW.Text), Convert.ToDouble(RPH.Text));


            Basic_sal.Text = Convert.ToString(ptE.getBasicSalary());
            lname_dis.Text = ptE.lastname;
            Fname_dis.Text = ptE.firstname;
        }
    }
}
