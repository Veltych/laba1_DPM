namespace OOP_Fundamentals_Library
{
    internal class ProgramExample
    {
        ///// ДАННЫЙ КОД НЕ ЗАПУСТИТСЯ, ЭТО ПРИМЕР ИСПОЛЬЗОВАНИЯ КЛАССОВ ИЗ БИБЛИОТЕКИ OOP_Fundamentals_Library
        ///// СКОПИРУЙТЕ ЕГО В МЕТОД MAIN ОСНОВОГО ПРОЕКТА ДЛЯ ПРОВЕРКИ РАБОТЫ
        static void Main(string[] args)
        {
            var customer = new Customer
            {
                Name = "John",
                Age = 30
            };
            
            var employee = new Employee
            {
                Name = "Alice",
                Age = 25,
                Position = "Developer"
            };
            employee.IncreaseSalary(50000);
            
            var manager = new Manager
            {
                Name = "Bob",
                Age = 40,
                Department = "IT"
            };
            manager.IncreaseSalary(80000);
            
            manager.Team.Add(employee);
            
            customer.PrintInfo();
            employee.PrintInfo();
            manager.PrintInfo();
            
            employee.ProcessPayroll();
            manager.ProcessPayroll();
            
            employee.ReportService();
            manager.ReportService();
            
            employee.IncreaseSalary(5000);
            Console.WriteLine($"Encrease salary {employee.Name}: {employee.Salary}");
            
            manager.AssignTaskToEmployee(employee, "Implement new feature");
       }
    }
}
