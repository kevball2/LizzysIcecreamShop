namespace LizzysIcecreamShop.HR
{
    public abstract class Worker: IWorker
    {
        private string firstName;
        private string lastName;
        private int age;
        private DateOnly birthday;
        private double? wage;
        private string employeeType;
        private int numberOfHoursWorked;
        private int employeeId;
        private DateOnly hiredate;
        private DateOnly? terminationdate;


        protected Worker(string first, string last, int emAge, DateOnly bday, double? rate, int emId, string emType, DateOnly emHireDate)
        {
            firstName = first;
            lastName = last;
            age = emAge;
            birthday = bday;
            wage = rate ?? 10;
            employeeId = emId;
            EmployeeType = emType;
            hiredate = emHireDate;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public DateOnly Birthday { get => birthday; set => birthday = value; }
        public double? Wage { get => wage; set => wage = value; }
        public int NumberOfHoursWorked { get => numberOfHoursWorked; set => numberOfHoursWorked = value; }
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public DateOnly Hiredate { get => hiredate; set => hiredate = value; }
        public DateOnly? Terminationdate { get => terminationdate; set => terminationdate = value; }
        public string EmployeeType { get => employeeType; set => employeeType = value; }

        public void PerformWork()
        {
            numberOfHoursWorked++;
            AnsiConsole.WriteLine($"Employee: {FirstName} {LastName} has worked {numberOfHoursWorked} hours");
        }

        public static void GiveWorkerRaise(List<IWorker> employeeList)
        {
            List<string> choices = new();
            foreach (IWorker worker in employeeList)
            {
                choices.Add($"{worker.FirstName} {worker.LastName} (Employee ID: {worker.EmployeeId})");
            }
            var selection = AnsiConsole.Prompt(new SelectionPrompt<string>()
                         .Title("Select a worker please:")
                         .AddChoices(choices));

            var selectedEmployee = employeeList.Find(s => selection.Contains(s.EmployeeId.ToString()));
           
            var oldWage = selectedEmployee.Wage;


            //var newWage = AnsiConsole.Ask<double>("Enter worker's new hourly rate: ");
            //while (newWage < oldWage)
            //{
            //    AnsiConsole.WriteLine($"Workers new wage must be greater than their prvious wage! Please enter a new wage greater than {oldWage}");
            //    newWage = AnsiConsole.Ask<double>($"Enter worker's new hourly rate: ");
            //}
            //selectedEmployee.wage = newWage;
            var newWage = AnsiConsole.Prompt(
               new TextPrompt<double>("Enter the workers new hourly wage: ")
                   .Validate(newWage =>
                   {
                       ValidationResult isNewWageGreater = newWage < oldWage ? ValidationResult.Error($"[red]New wage must be great than old wage: {oldWage}[/]") : ValidationResult.Success();
                       return isNewWageGreater;
                   }));
            AnsiConsole.WriteLine($"Employee: {selectedEmployee.FirstName} {selectedEmployee.LastName}'s wage has been change from {oldWage} to {newWage}");
            AnsiConsole.Write("\nPress any key to continue");
            Console.ReadKey(true);
           


            //foreach (var worker in employeeList)
            //{
            //    var fullName = $"{worker.firstName} {worker.lastName} (Employee ID: {worker.EmployeeId})";
            //    if (selection == fullName)
            //    {
            //        double oldWage = worker.wage;
            //        worker.wage = newWage;
            //        AnsiConsole.WriteLine($"Employee: {worker.firstName} {worker.lastName}'s wage has been change from {oldWage} to {newWage}");
            //        AnsiConsole.Write("\nPress any key to continue");
            //        Console.ReadKey(true);
            //    }
            //}



        }

        public abstract void DisplayEmployeeDetails();
        //{
        //AnsiConsole.WriteLine($"\nFirst Name: {FirstName}\nLast Name: {LastName}\nEmployee Id: {EmployeeId}");
        //}

        public static void DisplayAllEmployeesDetails(List<IWorker> employeeList)
        {
            var table = new Table();
            table.Border(TableBorder.Rounded);
            table.Title("Lizzy's Ice Cream Shop Employees");
            table.AddColumn("First Name");
            table.AddColumn("Last Name");
            table.AddColumn("Employee Id");
            table.AddColumn("Employee Type");
            table.AddColumn("Hourly Rate");
            table.AddColumn("Hire Date");

            foreach (Worker worker in employeeList)
            {
                //AnsiConsole.WriteLine($"\nFirst Name: {worker.FirstName}\nLast Name: {worker.LastName}\nEmployee Id: {worker.employeeId}" +
                //                      $"\nEmployee Type: {worker.employeeType}");
                table.AddRow($"{worker.firstName}", $"{worker.lastName}", $"{worker.employeeId}", $"{worker.employeeType}", $"{worker.wage}", $"{worker.hiredate}");
            }

            AnsiConsole.Write(table);
            AnsiConsole.Write("Press any key to continue");
            Console.ReadKey(true);
        }

        public static void DisplaySelectedEmployeeDetails(List<IWorker> employeelist)
        {
            List<string> choices = new();
            foreach (IWorker worker in employeelist)
            {
                choices.Add($"{worker.FirstName} {worker.LastName} (Employee ID: {worker.EmployeeId})");
            }
            var selection = AnsiConsole.Prompt( new SelectionPrompt<string>()
                         .Title("Select a worker please:")
                         .AddChoices(choices));

            foreach (var worker in employeelist)
            {
                var fullName = $"{worker.FirstName} {worker.LastName} (Employee ID: {worker.EmployeeId})";
                if (selection == fullName){

                    worker.DisplayEmployeeDetails();
                }
            }
            AnsiConsole.Write("Press any key to continue");
            Console.ReadKey(true);
        }

        public static bool IsValidDate(string bday)
        {
            // Check string format
            string pattern = @"^(0[1-9]|1[012])[-\/.](0[1-9]|[12][0-9]|3[01])[-\/.](19|20)\d\d$";
            return Regex.IsMatch(bday, pattern);
        }

        public static bool IsValidFirstName(string firstName)
        {
            // Check string format
            string pattern = @"^([a-zA-Z]{2,30}$)";
            return Regex.IsMatch(firstName, pattern);
        }

        public static bool IsValidLastName(string lastName)
        {
            // Check string format
            string pattern = @"^[a-zA-Z-]{2,30}$";
            return Regex.IsMatch(lastName, pattern);
        }
        public static bool IsValidateAge(int age)
        {
            // Try and parse string to int, if that fails then return false
            if (age < 15)
            {
                return false;
            }
            else if (age > 15)
            {
                return true;
            }
            else
            {
                return false;
            }

            // Check string format
            //string pattern = @"^(1[5-9]|2[0-9]|3[0-9]|4[0-9]|5[0-9]|6[0-9]|7[0-9]|8[0-9]|9[0-9]|10[0-9]|11[0-9])";
            //return Regex.IsMatch(age, pattern);
        }

    }
}
