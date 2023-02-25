using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstOOPCode_Saturday
{
    public class BaseCommissionEmployee : CommissionEmployee
    {

        #region Properties

        public decimal Base { get; set; }

        #endregion

        #region Methods

        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Base;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Base......................{Base:C2}\n\t" +
                $"Total Value to pay........{GetValueToPay():C2}";
        }

        #endregion
    }
}
