namespace OOP_Fundamentals_Library
{
    public abstract class AbsEmployee : Person
    {
        public string Position { get; set; }
        public decimal Salary { get; protected set; }
        public abstract void ProcessPayroll();
        public abstract decimal CalculateBonus(int years, bool hasCertification);
        public abstract void ReportService();

        public void IncreaseSalary(decimal amount)
        {
            if (amount > 0)
                Salary += amount;
        }
    }

    public class Employee : AbsEmployee
    {
        public override void ProcessPayroll()
        {
            Console.WriteLine($"Processing payroll for {Name}: {Salary}");
        }

        public override decimal CalculateBonus(int years, bool hasCertification)
        {
            var bonus = Salary * 0.1m;
            if (years > 5) bonus += 500;
            if (hasCertification) bonus += 300;
            return bonus;
        }
        public override void ReportService() {
            Console.WriteLine($"Employee Report:");
            Console.WriteLine($"  Name: {Name}");
            Console.WriteLine($"  Age: {Age}");
            Console.WriteLine($"  Salary: {Salary}");
        }

    }
}
