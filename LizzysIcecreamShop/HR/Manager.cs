namespace LizzysIcecreamShop.HR
{
    internal sealed class Manager : Worker
    {
        private int bonus;
        private const string employeeType = "Manager";
        public int Bonus { get => bonus; set => bonus = value; }

        public Manager(string first, string last, int emAge, DateOnly bday, double? rate, int emId, DateOnly emHireDate) : base(first, last, emAge, bday, rate, emId, employeeType, emHireDate)
        { }

        public Manager(string first, string last, int emAge, DateOnly bday, double? rate, int emId, DateOnly emHireDate, int emBonus) : base(first, last, emAge, bday, rate, emId, employeeType, emHireDate)
        {
            Bonus = emBonus;
        }

        public override void DisplayEmployeeDetails()
        {
            AnsiConsole.WriteLine($"\nFirst Name: {FirstName}\nLast Name: {LastName}\nEmployee Id: {EmployeeId}\nEmployee Type: {employeeType}" +
                                  $"\nWage: {Wage}\nHire Date: {Hiredate}\nBonus: {Bonus}");
            AnsiConsole.Write("Press any key to continue");
            Console.ReadKey(true);
        }

        public static void UpdateWorkerTitle(List<IWorker> employeeList)
        {
            List<string> employeeChoices = new();
            foreach (IWorker worker in employeeList)
            {
                employeeChoices.Add($"{worker.FirstName} {worker.LastName} (Employee ID: {worker.EmployeeId})");
            }
            var selection = AnsiConsole.Prompt(new SelectionPrompt<string>()
                         .Title("Select a worker please:")
                         .AddChoices(employeeChoices));

            var selectedEmployee = employeeList.Find(s => selection.Contains(s.EmployeeId.ToString()));
            var oldTitle = selectedEmployee.EmployeeType;
            List<string> employeeTypeChoices = new();
            foreach (IWorker worker in employeeList)
            {
                if (!employeeTypeChoices.Contains(worker.EmployeeType.ToString()) && !selectedEmployee.EmployeeType.Contains(worker.EmployeeType.ToString()))
                    employeeTypeChoices.Add($"{worker.EmployeeType}");
            }

            var newTitle = AnsiConsole.Prompt(new SelectionPrompt<string>()
                         .Title("Select workers new title:")
                         .AddChoices(employeeTypeChoices));

            selectedEmployee.EmployeeType = newTitle;
            AnsiConsole.WriteLine($"Employee: {selectedEmployee.FirstName} {selectedEmployee.LastName}'s title has been change from {oldTitle} to {newTitle}");
            AnsiConsole.Write("\nPress any key to continue");
            Console.ReadKey(true);

        }
    }
}
