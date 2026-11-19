using System;

namespace EmploySalarySystem_RunTImePolymorphism_withVirtual
{
    class employee
    {
        public string name { get; set; }
        public int hourlyworked { get; set; }

        public double hourlyrate { get; set; }

        // we need to declare the virtual method using virtual
        public virtual double CalculateSalary()
        {
            return hourlyrate* hourlyworked;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Employ Name : {name}");
            Console.WriteLine($"Employ Houtly Worked : {hourlyworked}");
            Console.WriteLine($"Employ Hourly Rate : {hourlyrate}");
        }
    }

    class permanentEmployee : employee
    {
        public override double CalculateSalary()
        {
            double basesalary = base.CalculateSalary();         // base.calculatesal() is calling the isrual class
            double bonus = basesalary * 0.10;
            return bonus + basesalary;
        }
    }

    class ContractEmployee : employee
    {
        public override double CalculateSalary()
        {
            double basesalary = hourlyrate * hourlyworked;
            double deduction = basesalary * 0.10;
            return deduction - basesalary;
        }

    }

    class Freelancer : employee
    {
        public override double CalculateSalary()
        {
            
            return 9999.99;
        }
    }
    class program
    {
        static void Main()
        {
            employee emp1 = new permanentEmployee();
            emp1.hourlyrate = 950.10;
            emp1.hourlyworked = 30;
            emp1.name = "RAJ";
            var salary1 = emp1.CalculateSalary();     // abstract method
            emp1.DisplayDetails();      // non abstract method
        }
    }
}
