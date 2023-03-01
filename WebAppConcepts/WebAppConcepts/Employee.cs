using System;

namespace WebAppConcepts
{
    public abstract class Employee
    {
        #region Properties

        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }


        #endregion

        #region Methods
        public abstract decimal GetValueToPay();


        public override string ToString()
        {
            return $"----EMPLOYEE---\n\t" +
                $"ID.... {Id}\n\t" +
                $"Firts  Name .... {FirstName}\n\t" +
                $"Last   Name .... {LastName}\n\t" +
                $"Birth  Date .... {BirthDate}\n\t" +
                $"Hiring Date .... {HiringDate} \n\t" +
                $"Is     Active .... {IsActive} \n\t";
        }

        #endregion


    }
}
