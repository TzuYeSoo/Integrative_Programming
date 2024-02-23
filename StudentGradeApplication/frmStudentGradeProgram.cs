using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class frmStudentGradeProgram : Form
    {
        public frmStudentGradeProgram()
        {
            InitializeComponent();
        }

       
        

        private void generate_grades_Click(object sender, EventArgs e)
        {
            string Student_Name = Name_T.Text;
            double English = Convert.ToDouble(EnglishG.Text);
            double Math = Convert.ToDouble(MathG.Text);
            double Science = Convert.ToDouble(ScienceG.Text);
            double Filipino = Convert.ToDouble(FilipinoG.Text);
            double History = Convert.ToDouble(HistoryG.Text);

            double Average_Grades = (English + Math + Science + History + Filipino) / 5;
            Result.Text = Average_Grades >= 75 ? Student_Name + " Grade "+ Average_Grades +"\n is Above average therfor you Pass this Term" : Student_Name + " Grade " + Average_Grades + "\n is below Average therfor you Failed this Term";


        }

    }
}
