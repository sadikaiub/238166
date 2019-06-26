using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorAppPractice3
{
    public partial class SalaryCalculatorUi : Form
    {
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }


        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {
            Salary salary = new Salary();
            salary.EmployeeName = employeeNameTextBox.Text;
            salary.BasicAmount = Convert.ToDouble(basicAmountTextBox.Text);
            salary.HomeRent = Convert.ToDouble(homeRentTextBox.Text);
            salary.MedicalAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);

            MessageBox.Show(salary.EmployeeName + " Your Salary Is: " + salary.TotalSalary());
        }
    }
}
