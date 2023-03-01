using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppConcepts
{
    internal class ComissionEmployee: Employee
    {
        #region Properties

        public double CommissionPercentage { get; set; }
        public decimal Sales { get; set; }

        #endregion

        public override decimal GetValueToPay()
        {
            return Sales * Convert.ToDecimal(CommissionPercentage/100);
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Commission Percentage .... {CommissionPercentage/100:P2}\n\t" +
                $"Sales .... {Sales:C2}" +
                $"Get Value To Pay .... {GetValueToPay():C2}\n\t";
        }
    }
}
