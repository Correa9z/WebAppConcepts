using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppConcepts
{
    public class SalaryEmployee : Employee
    {
        #region Properties

        public decimal Salary { get; set; }

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
