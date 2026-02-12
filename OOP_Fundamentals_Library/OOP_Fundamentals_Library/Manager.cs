namespace OOP_Fundamentals_Library
{
    public class Manager : AbsEmployee
    {
        public string Department {  get; set; }
        public List<Employee> Team { get; } = new();

        public void AssignTaskToEmployee(Employee emp, string task)
        {
            Console.WriteLine($"Assigning task '{task}' to {emp.Name}");
        }
        public override void ProcessPayroll()
        {
            Console.WriteLine($"Processing payroll for manager {Name}: {Salary}");
        }

        public override decimal CalculateBonus(int years, bool hasCertification)
        {
            var bonus = Salary * 0.2m;
            if (years > 5) bonus += 500;
            if (hasCertification) bonus += 300;
            return bonus;
        }
        public override void ReportService()
        {
            Console.WriteLine($"Manager Report:");
            Console.WriteLine($"  Name: {Name}");
            Console.WriteLine($"  Age: {Age}");
            Console.WriteLine($"  Salary: {Salary}");
        }
    }
}
