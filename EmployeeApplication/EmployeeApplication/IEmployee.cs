using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIntrerface
{
    internal interface IEmployee
    {

       string firstname{ get; set;}
       string lastname { get; set;}

        string Department { get; set;}

        string JobTitle { get; set;}

        double BasicSalary { get; set; }

        void computeSalary(int hourWorked, double rateperhour);


    }
}
