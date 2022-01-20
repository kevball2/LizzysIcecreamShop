


namespace LizzysIcecreamShop.HR
{
    internal sealed class Employee : IWorker
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


        public Employee(string first, string last, int emAge, DateOnly bday, double? rate, int emId, DateOnly emHireDate) 
        {
            firstName = first;
            lastName = last;
            age = emAge;
            birthday = bday;
            wage = rate ?? 10;
            employeeId = emId;
            hiredate = emHireDate;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName ; set => lastName = value; }
        public int Age { get => age ; set => age = value; }
        public DateOnly Birthday { get => birthday ; set => birthday = value; }
        public double? Wage { get => wage ; set => wage = value ; }
        public int NumberOfHoursWorked { get => numberOfHoursWorked ; set => numberOfHoursWorked = value ; }
        public int EmployeeId { get => employeeId ; set => employeeId = value; }
        public DateOnly Hiredate { get => hiredate ; set => hiredate = value; }
        public DateOnly? Terminationdate { get => terminationdate ; set => terminationdate = value ; }
        public string EmployeeType { get => employeeType; set => employeeType = "Employee"; }

        
        public void DisplayEmployeeDetails()
        {
          AnsiConsole.WriteLine($"\nFirst Name: {FirstName}\nLast Name: {LastName}\nEmployee Id: {EmployeeId}" +
                                $"\nEmployee Type: {employeeType}");
        }

    }
    
}
