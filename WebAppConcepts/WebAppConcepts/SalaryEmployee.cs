using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppConcepts
{
    public class CommissionEmployee : Employee
    {
        #region Properties

        public decimal Salary { get; set; }
        public double CommissionPercentage { get; internal set; }
        public int Sales { get; internal set; }

        #endregion

        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Salary .... {GetValueToPay():C2}";
        }
    }
}
