using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorAppPractice3
{
    public class Salary
    {
        public string EmployeeName { get; set; }
        public double BasicAmount { get; set; }
        public double HomeRent { get; set; }
        public double MedicalAllowance { get; set; }


        public double percentageHomeRent()
        {
            double pHomeRent =BasicAmount * (HomeRent / 100);
            return pHomeRent;
        }

        public double percentageMedicalAllowance()
        {
            double pMedicalAllowance = BasicAmount * (MedicalAllowance / 100);
            return pMedicalAllowance;
        }

        public double TotalSalary()
        {
            return BasicAmount + percentageHomeRent()+percentageMedicalAllowance();
        }
    }
}
