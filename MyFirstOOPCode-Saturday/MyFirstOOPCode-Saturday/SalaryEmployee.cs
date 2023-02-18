using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstOOPCode_Saturday
{
    public class SalaryEmployee : Employee
    {
        #region Properties
        public decimal Salary { get; set; }
        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()} \n\t" +
                $"Value to pay.....{GetValueToPay():C2}";
        }
        #endregion
    }
}
