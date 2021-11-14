namespace LizzysIcecreamShop.HR
{
    public abstract class Worker
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

        protected string FirstName { get => firstName; set => firstName = value; }
        protected string LastName { get => lastName; set => lastName = value; }
        protected int Age { get => age; set => age = value; }
        protected DateOnly Birthday { get => birthday; set => birthday = value; }
        protected double? Wage { get => wage; set => wage = value; }
        public int NumberOfHoursWorked { get => numberOfHoursWorked; set => numberOfHoursWorked = value; }
        protected int EmployeeId { get => employeeId; set => employeeId = value; }
        protected DateOnly Hiredate { get => hiredate; set => hiredate = value; }
        protected DateOnly? Terminationdate { get => terminationdate; set => terminationdate = value; }
        protected string EmployeeType { get => employeeType; set => employeeType = value; }

        public void PerformWork()
        {
            numberOfHoursWorked++;
            AnsiConsole.WriteLine($"Employee: {FirstName} {LastName} has worked {numberOfHoursWorked} hours");
        }

        public abstract void DisplayEmployeeDetails();
        //{
        //AnsiConsole.WriteLine($"\nFirst Name: {FirstName}\nLast Name: {LastName}\nEmployee Id: {EmployeeId}");
        //}

        public static void DisplayAllEmployeesDetails(List<Worker> employeelist)
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

            foreach (Worker worker in employeelist)
            {
                //AnsiConsole.WriteLine($"\nFirst Name: {worker.FirstName}\nLast Name: {worker.LastName}\nEmployee Id: {worker.employeeId}" +
                //                      $"\nEmployee Type: {worker.employeeType}");
                table.AddRow($"{worker.firstName}", $"{worker.lastName}", $"{worker.employeeId}", $"{worker.employeeType}", $"{worker.wage}", $"{worker.hiredate}");
            }

            AnsiConsole.Write(table);
            AnsiConsole.Write("Press any key to continue");
            Console.ReadKey(true);
        }

        public static void DisplaySelectedEmployeeDetails(List<Worker> employeelist)
        {
            List<string> choices = new();
            foreach (Worker worker in employeelist)
            {
                choices.Add($"{worker.firstName} {worker.lastName} (Employee ID: {worker.EmployeeId})");
            }
            var selection = AnsiConsole.Prompt( new SelectionPrompt<string>()
                         .Title("Select a worker please:")
                         .AddChoices(choices));

            foreach (var worker in employeelist)
            {
                var fullName = $"{worker.firstName} {worker.lastName} (Employee ID: {worker.EmployeeId})";
                if (selection == fullName){

                    worker.DisplayEmployeeDetails();
                }
            }
            AnsiConsole.Write("Press any key to continue");
            Console.ReadKey(true);
        }

        public static bool IsValidBirthday(string bday)
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
                return true;
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
