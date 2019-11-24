using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal=new Calculator();
           
            cal.em_id = Convert.ToInt32(Console.ReadLine());
           
            cal.em_name = Console.ReadLine();
           
            cal.em_position = Console.ReadLine();
           
            cal.em_gendeer= Console.ReadLine();
            
            double grossSalary;
            grossSalary = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine($"{cal.em_name} your monthly salary on position of {cal.em_position}   is {cal.MonthlySalary(grossSalary)}");
            
            Console.WriteLine($"{cal.em_name} your one-time salary on position of {cal.em_position} is {cal.OneTimeSalary(grossSalary)}");
                
            Console.WriteLine("Enter your rate ");
            double rate;
            rate = Convert.ToDouble(Console.ReadLine());
            
            double hour;
            hour = Convert.ToDouble(Console.ReadLine());
            if (rate != 0 && hour != 0)
            {
                Console.WriteLine($"{cal.em_name} Your hourly salary is {cal.HourlySalary(rate,hour)}");
            }
            else
            {
                Console.WriteLine(" Your hourly salary is 0");
            }
            
           
            
            
        }
    }
}