using System;
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

                Console.WriteLine(salaryEmployee.ToString());

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

                Console.WriteLine(commissionEmployee.ToString());

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

                Console.WriteLine(hourlyEmployee.ToString());

                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
