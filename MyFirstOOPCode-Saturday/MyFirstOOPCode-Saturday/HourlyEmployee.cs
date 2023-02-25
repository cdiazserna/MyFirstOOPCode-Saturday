using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstOOPCode_Saturday
{
    public class HourlyEmployee : Employee
    {
        #region Properties

        public float Hours { get; set; }
        public decimal HourValue { get; set; }

        #endregion

        #region Methods

        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Hours.....................{Hours:N2}\n\t" +
                $"Value per hour............{HourValue:C2}\n\t" +
                $"Value to Pay..............{GetValueToPay():C2}";
        }

        #endregion


    }
}
