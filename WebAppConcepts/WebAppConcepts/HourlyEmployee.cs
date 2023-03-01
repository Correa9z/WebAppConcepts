using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppConcepts
{
    public class HourlyEmployee: Employee
    {

        #region Properties
        public float Hours { get; set; }
        public decimal HourValue { get; set; }
        #endregion

        public override decimal GetValueToPay()
        {
            return HourValue * (decimal)Hours;

        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Hours  .... {Hours}\n\t" +
                $"Value per Hour .... {HourValue:C2}\n\t" +
                $"Get Value To Pay .... {GetValueToPay():C2}\n\t";
        }

    }
}
