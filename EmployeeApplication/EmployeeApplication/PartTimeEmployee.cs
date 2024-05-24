using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeIntrerface;

namespace EmployeeApplication
{
    internal class PartTimeEmployee : IEmployee
    {
        private string first_name;
        private string last_name;
        private string department;
        private string JobTitles;
        private double BasicSal;

        public PartTimeEmployee(string fname, string lname, string Dep, string JobT)
        {
            this.first_name = fname;
            this.last_name = lname;
            this.department = Dep;
            this.JobTitles = JobT;
        }
        public string firstname
        {
            get
            {
                return first_name;
            }
            set
            {
                first_name = value;
            }
        }

        public string lastname { 
            get {
                return last_name;
            }set {
                last_name = value;
            }
        
        }

        public string Department {
            get {
                return department;
                    
            }set { 
                department = value;
            }
        }
        public string JobTitle { 
            get{
                return JobTitles;
            }
            set
            {
                JobTitle = JobTitles;
            }
        }
        public double BasicSalary {
            get { 
                return BasicSal; }
            set 
            {
                BasicSal = value;
            }
        }
        public void computeSalary(int hourWorked, double rateperhour)
        {
            BasicSal = hourWorked * rateperhour;

        }
        public double getBasicSalary()
        {
            return BasicSal;
        }
    }
}
