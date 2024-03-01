using System.Security.AccessControl;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }
        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {
            
            string[] Mname = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            for (int i = 0; i < 12; i++)
            {
                Month.Items.Add(Mname[i]);
            }

            for (int i = 1900; i <= 2024; i++)
            {
                Year.Items.Add(i);
            }
            if(Month.Text == "January")
            {
                for (int i = 1; i <= 31; i++)
                {
                Day.Items.Add(i);
                }
            }
            else
            {
                for (int i = 1; i <= 30; i++)
                {
                    Day.Items.Add(i);
                }

            }
            

           
           
        }

        private void Register_Click(object sender, EventArgs e)
        {
            string gen;
            string Fname = FirstName.Text;
            string Lname = LastName.Text;
            string Mname = MiddleName.Text;

            if (Male.Checked == true)
            {
                gen = "Male";
            }
            else
            {
                gen = "Female";
            }
            MessageBox.Show("Student Name: " + Fname + " " + Mname + " " + Lname
                +"\nGender: " + gen
                +"\nDate of Birth: " + Day.Text + "/" + Month.Text + "/" + Year.Text);




        }


    }
}