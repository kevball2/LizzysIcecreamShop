namespace LizzysIcecreamShop.HR
{
    public interface IWorker
    {
       
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        DateOnly Birthday { get; set; }
        double? Wage { get; set; }
        int NumberOfHoursWorked { get; set; }
        int EmployeeId { get; set; }
        DateOnly Hiredate { get; set; }
        DateOnly? Terminationdate { get; set; }
        string EmployeeType { get; set; }

        public void PerformWork()
        {
            
        }

        public static void GiveWorkerRaise(List<IWorker> employeeList)
        {
            
        }

        public abstract void DisplayEmployeeDetails();
        //{
        //AnsiConsole.WriteLine($"\nFirst Name: {FirstName}\nLast Name: {LastName}\nEmployee Id: {EmployeeId}");
        //}

        public static void DisplayAllEmployeesDetails(List<IWorker> employeeList)
        {
  
        }

        public static void DisplaySelectedEmployeeDetails(List<IWorker> employeelist)
        {
           
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
