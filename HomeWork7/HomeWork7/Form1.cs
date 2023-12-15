using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork7
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        EmployeeDataContainer context = new EmployeeDataContainer();
        private void Form1_Load(object sender, EventArgs e)
        {
           

            var Employees=context.Employees.ToList();


            

            metroGrid.DataSource = Employees;
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            int Department = 1;

            switch (DepartmentCB.Text)
            {
                case "IT": Department = 1;
                    break;
                case "HR": Department = 2;
                    break;
                case "Payroll": Department = 3;
                    break;
            }




            var employee = new Employee()
            {

                FirstName = FirstNameTB.Text,
                LastName = LastNameTB.Text,
                Gender = GenderCB.Text,
                Salary = SalaryTB.Text,
                DepartmentId = Department

            };

            context.Employees.Add(employee);
            context.SaveChanges();
            var Employees = context.Employees.ToList();
            metroGrid.DataSource = Employees;

        }
    }
}
