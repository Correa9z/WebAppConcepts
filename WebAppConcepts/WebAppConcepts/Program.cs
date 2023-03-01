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

                CommissionEmployee prueba = new CommissionEmployee() 
                {
                    Id = 1,
                    FirstName = "Patricia",
                    LastName = "Alvarez",
                    BirthDate = dateObject,
                    HiringDate = dateObject,
                    IsActive = true,
                    CommissionPercentage = 0.05,
                    Sales = 20000000
                };

                Employee CoEmployee = new CommissionEmployee()
                {
                   Id = 1,
                   FirstName = "Patricia",
                   LastName = "Alvarez",
                   BirthDate = dateObject,
                   HiringDate = dateObject,
                   IsActive = true,
                   CommissionPercentage = 0.05,
                   Sales = 20000000 
                };

                Console.Write("Please type your id: ");
                int id = Int16.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Please type your First Name: ");
                String firstName = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Please type your Last Name: ");
                String lastName = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Please type your active: ");
                bool isActive = Boolean.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Please type your hours: ");
                float hours = float.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Please type your hour value: ");
                decimal hourValue = decimal.Parse(Console.ReadLine());
                Console.WriteLine();


                Employee hourlyEmployee = new HourlyEmployee()
                {
                    Id = 1,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = dateObject,
                    HiringDate = dateObject,
                    IsActive = isActive,
                    Hours = hours,
                    HourValue = hourValue
                    

                };

                Console.WriteLine(hourlyEmployee);
                

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}
