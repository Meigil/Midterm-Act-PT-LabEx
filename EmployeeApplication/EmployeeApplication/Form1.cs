using System;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class PartTimeEmployee : Form
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
            public string JobTitle { get; set; }
            public double BasicSalary { get; set; }

        
            public PartTimeEmployee(string fName, string lName, string department, string jobTitle)
            {
                FirstName = fName;
                LastName = lName;
                Department = department;
                JobTitle = jobTitle;
                BasicSalary = 0.0; 
            }

         
            public void ComputeSalary(int hoursWorked, double ratePerHour)
            {
                BasicSalary = hoursWorked * ratePerHour;
            }
        }

        private void ComputeSalary_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string department = txtDepartment.Text;
            string jobTitle = txtJobTitle.Text;
            double ratePerHour;
            int totalHoursWorked;

            if (double.TryParse(txtRatePerHour.Text, out ratePerHour) &&
                int.TryParse(txtTotalHoursWorked.Text, out totalHoursWorked))
            {
               
                PartTimeEmployee employee = new PartTimeEmployee(firstName, lastName, department, jobTitle);

                employee.ComputeSalary(totalHoursWorked, ratePerHour);

                label7.Text = $"First name: {employee.FirstName}";
                label8.Text = $"First name: {employee.LastName}";
                lblBasicSalary.Text = $"Basic Salary: {employee.BasicSalary.ToString("C")}";
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for Rate per Hour and Total Hours Worked.");
            }
        }
    }
}
