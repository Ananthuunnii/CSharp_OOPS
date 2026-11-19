using System;

namespace EmploySalarySystemCompileTimePolymorphism
{
    public class EmploySalaryCalculation
    {
        // fixed monthly based salary
        public double CalculateSalary(double MonthlySalary)
        {
            return MonthlySalary;
        }

        // hourly based salary
        public double CalculateSalary(int hourlyworked, int hourlyrate)
        {
            return hourlyworked * hourlyrate;
        }

        //sales based salary
        public double CalculateSalary(double salesamount, double commisionrate,bool isSales)
        {
            return salesamount * commisionrate;
        }

        //freelance salary with bonus
        public double CalculateSalary(int workhour,int hourlyrate, double bonus)
        {
            return (hourlyrate * workhour) + bonus;

        }

    }

    class Program
    {
        static void Main()
        {
            EmploySalaryCalculation empsalcal = new EmploySalaryCalculation();
            double salary1 = empsalcal.CalculateSalary(130000);
            Console.WriteLine($"salary1 : {salary1}");
            double salary2 = empsalcal.CalculateSalary(8,1200);
            Console.WriteLine($"salary2 : {salary2}");
            double salary3 = empsalcal.CalculateSalary(10000.5,1.5,true);
            Console.WriteLine($"salary3 : {salary3}");
            double salary4 = empsalcal.CalculateSalary(40,950,5000.45);
            Console.WriteLine($"salary4 : {salary4}");

        }
    }
}
