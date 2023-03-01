using System;

namespace WebAppConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("*****************************");
                Console.WriteLine("         Date Class");
                Console.WriteLine("*****************************");
                Console.WriteLine("");
                Console.Write("Please type your year: ");
                int year = Int16.Parse(Console.ReadLine());
               
                Console.WriteLine("");
                Console.Write("Please type your month: ");
                int month = Int16.Parse(Console.ReadLine());
                
                Console.WriteLine("");
                Console.Write("Please type your day: ");
                int day = Int16.Parse(Console.ReadLine());
                
                Console.WriteLine("");
                Date dateObject = new Date(year, month, day);
                
                Console.WriteLine("The date entereer is: " + dateObject);


                Employee salaryEmployee = new SalaryEmployee()
                {
                   Id = 1,
                   FirstName = "Patricia",
                   LastName = "Alvarez",
                   BirthDate = dateObject,
                   HiringDate = dateObject,
                   IsActive = true,
                   Salary = 1160000
                };


                Console.WriteLine(salaryEmployee);
                

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}
