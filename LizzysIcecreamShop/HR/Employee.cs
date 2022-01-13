


namespace LizzysIcecreamShop.HR
{
    internal sealed class Employee : Worker
    {
        //private string firstName;
        //private string lastName;
        //private int age;
        //private DateOnly birthday;
        //private double? wage;
        private const string employeeType = "Employee";
        //private int numberOfHoursWorked;
        //private int employeeId;
        //private DateOnly hiredate;
        //private DateOnly? terminationdate;


        public Employee(string first, string last, int emAge, DateOnly bday, double? rate, int emId, DateOnly emHireDate):
                           base(first, last, emAge, bday, rate, emId, employeeType, emHireDate)
        {
            //firstName = first;
            //lastName = last;
            //age = emAge;
            //birthday = bday;
            //wage = rate ?? 10;
            //employeeId = emId;
            //hiredate = emHireDate;
        }

        public override void DisplayEmployeeDetails()
        {
          AnsiConsole.WriteLine($"\nFirst Name: {FirstName}\nLast Name: {LastName}\nEmployee Id: {EmployeeId}" +
                                $"\nEmployee Type: {employeeType}");
        }

    }
    
}
