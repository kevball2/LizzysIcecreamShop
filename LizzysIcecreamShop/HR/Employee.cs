


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

        //protected string FirstName { get => firstName; set => firstName = value; }
        //protected string LastName { get => lastName; set => lastName = value; }
        //protected int Age { get => age; set => age = value; }
        //protected DateOnly Birthday { get => birthday; set => birthday = value; }
        //protected double? Wage { get => wage; set => wage = value; }
        //public int NumberOfHoursWorked { get => numberOfHoursWorked; set => numberOfHoursWorked = value; }
        //protected int EmployeeId { get => employeeId; set => employeeId = value; }
        //protected DateOnly Hiredate { get => hiredate; set => hiredate = value; }
        //protected DateOnly? Terminationdate { get => terminationdate; set => terminationdate = value; }

        //public void PerformWork()
        //{
        //    numberOfHoursWorked++;
        //    AnsiConsole.WriteLine($"Employee: {FirstName} {LastName} has worked {numberOfHoursWorked} hours");
        //}

        public override void DisplayEmployeeDetails()
        {
          AnsiConsole.WriteLine($"\nFirst Name: {FirstName}\nLast Name: {LastName}\nEmployee Id: {EmployeeId}" +
                                $"\nEmployee Type: {employeeType}");
        }

        //public static bool IsValidBirthday(string bday)
        //{
        //    // Check string format
        //    string pattern = @"^(0[1-9]|1[012])[-\/.](0[1-9]|[12][0-9]|3[01])[-\/.](19|20)\d\d$";
        //    return Regex.IsMatch(bday, pattern);
        //}

        //public static bool IsValidFirstName(string firstName)
        //{
        //    // Check string format
        //    string pattern = @"^([a-zA-Z]{2,30}$)";
        //    return Regex.IsMatch(firstName, pattern);
        //}

        //public static bool IsValidLastName(string lastName)
        //{
        //    // Check string format
        //    string pattern = @"^[a-zA-Z-]{2,30}$";
        //    return Regex.IsMatch(lastName, pattern);
        //}
        //public static bool IsValidateAge(int age)
        //{
        //    // Try and parse string to int, if that fails then return false
        //    if (age < 15)
        //    {
        //        return true;
        //    }
        //    else if(age > 15)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
            
            // Check string format
            //string pattern = @"^(1[5-9]|2[0-9]|3[0-9]|4[0-9]|5[0-9]|6[0-9]|7[0-9]|8[0-9]|9[0-9]|10[0-9]|11[0-9])";
            //return Regex.IsMatch(age, pattern);
        }
    
}
