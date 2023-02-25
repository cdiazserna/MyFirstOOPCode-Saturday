using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;

namespace MyFirstOOPCode_Saturday
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var dateObjectBirthDate = new Date(1920, 2, 8);
                var dateObjectHiringDate = new Date(2023, 1, 1);

                Console.WriteLine("");

                Console.WriteLine("*******************");
                Console.WriteLine("* SALARY EMPLOYEE *");
                Console.WriteLine("*******************");

                Employee salaryEmployee = new SalaryEmployee()
                {
                    Id= 104580581,
                    FirstName = "Maria",
                    LastName = "Sandoval",
                    BirthDate = dateObjectBirthDate,
                    HiringDate = dateObjectHiringDate,
                    IsActive = true,
                    Salary = 1600000.56M
                };

                //Console.WriteLine(salaryEmployee.ToString());

                Console.WriteLine("");

                Console.WriteLine("***********************");
                Console.WriteLine("* COMMISSION EMPLOYEE *");
                Console.WriteLine("***********************");

                Console.WriteLine("");

                Console.WriteLine("Type your ID:");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type your first name:");
                string firstName = Console.ReadLine();

                Console.WriteLine("Type your last name:");
                string lastName = Console.ReadLine();

                Console.WriteLine("Are you active?");
                bool isActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Type your commission in percentage");
                float commissionPercentage = Convert.ToSingle(Console.ReadLine());
                commissionPercentage = commissionPercentage / 100;

                Console.WriteLine("Type your sales");
                decimal sales = Convert.ToDecimal(Console.ReadLine());

                Employee commissionEmployee = new CommissionEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = dateObjectBirthDate,
                    HiringDate = dateObjectHiringDate,
                    IsActive = isActive,
                    CommissionPercentage = commissionPercentage,
                    Sales = sales
                };

                //Console.WriteLine(commissionEmployee.ToString());

                Console.WriteLine("");

                Console.WriteLine("*******************");
                Console.WriteLine("* HOURLY EMPLOYEE *");
                Console.WriteLine("*******************");

                Console.WriteLine("");

                Console.WriteLine("Type your ID:");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type your first name:");
                firstName = Console.ReadLine();

                Console.WriteLine("Type your last name:");
                lastName = Console.ReadLine();

                Console.WriteLine("Are you active?");
                isActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Type your number of hours:");
                float hours = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Type your value per hour: ");
                decimal hourValue = Convert.ToDecimal(Console.ReadLine());

                Employee hourlyEmployee = new HourlyEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = dateObjectBirthDate,
                    HiringDate = dateObjectHiringDate,
                    IsActive = isActive,
                    Hours = hours,
                    HourValue = hourValue
                };

                //Console.WriteLine(hourlyEmployee.ToString());

                Console.WriteLine("");

                Console.WriteLine("****************************");
                Console.WriteLine("* BASE COMMISSION EMPLOYEE *");
                Console.WriteLine("***************************");

                Console.WriteLine("");

                Console.WriteLine("Type your ID:");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type your first name:");
                firstName = Console.ReadLine();

                Console.WriteLine("Type your last name:");
                lastName = Console.ReadLine();

                Console.WriteLine("Are you active?");
                isActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Type your commission in percentage");
                commissionPercentage = Convert.ToSingle(Console.ReadLine());
                commissionPercentage = commissionPercentage / 100;

                Console.WriteLine("Type your sales");
                sales = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Type your salary base:");
                decimal baseSalary = Convert.ToDecimal(Console.ReadLine());

                Employee baseCommissionEmployee = new BaseCommissionEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = dateObjectBirthDate,
                    HiringDate = dateObjectHiringDate,
                    IsActive = isActive,
                    CommissionPercentage = commissionPercentage,
                    Sales = sales,
                    Base = baseSalary
                };

                //Console.WriteLine(baseCommissionEmployee.ToString());

                decimal payroll = 0;
                List<string> names = new List<string>();

                ICollection<Employee> employees = new List<Employee>()
                {
                    salaryEmployee,
                    commissionEmployee,
                    hourlyEmployee,
                    baseCommissionEmployee
                };

                foreach (Employee employee in employees)
                {
                    if (employee.IsActive == true)
                    {
                        Console.WriteLine(employee);
                        names.Add(employee.FirstName);
                        payroll += employee.GetValueToPay();
                        Console.WriteLine("");
                    }

                }

                foreach (string name in names)
                {
                    Console.WriteLine(name);
                    Console.WriteLine("");
                }

                Console.WriteLine(String.Format("Total Payroll:..........{0:C2}", payroll));

                Console.WriteLine("");

                Console.WriteLine("************");
                Console.WriteLine("* INVOICEE *");
                Console.WriteLine("************");

                Console.WriteLine("");

                Invoice invoice = new Invoice()
                {
                    Id = 102030,
                    Description = "iPhone 14 Pro Max Plus Super Beta",
                    Price = 1500M,
                    Quantity = 2
                };

                Console.WriteLine(invoice);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
