
namespace LizzysIcecreamShop
{
    public class helper
    {
        public static void HireWorker(List<IWorker> workerList, string jobRole)
        {
            if (workerList is null)
            {
                throw new ArgumentNullException(nameof(workerList));
            }
            string first = AnsiConsole.Ask<string>($"Enter {jobRole}'s First Name:");
            while (Worker.IsValidFirstName(first) == false)
            {
                AnsiConsole.WriteLine($"Please enter a valid first name for the {jobRole}");
                first = AnsiConsole.Ask<string>($"Enter {jobRole}'s First Name:");
            }
            string last = AnsiConsole.Ask<string>($"Enter {jobRole}'s Last Name:");
            while (Worker.IsValidLastName(last) == false)
            {
                AnsiConsole.WriteLine("Please enter a valid last name for the {jobRole}");
                last = AnsiConsole.Ask<string>($"Enter {jobRole}'s Last Name:");
            }
            int emAge = AnsiConsole.Ask<int>($"Enter {jobRole}'s Age:");
            while (Worker.IsValidateAge(emAge) == false)
            {
                AnsiConsole.WriteLine("Incorrect format specified, please enter the birthday in the following format: MM/DD/YYY");
                emAge = AnsiConsole.Ask<int>($"Please enter a valid age for the {jobRole}:");
            }
            string stringBday = AnsiConsole.Ask<string>($"Enter {jobRole}'s Birthday (MM/DD/YYYY):");
            while (Worker.IsValidDate(stringBday) == false)
            {
                AnsiConsole.WriteLine("Incorrect format specified, please enter the birthday in the following format: MM/DD/YYY");
                stringBday = AnsiConsole.Ask<string>($"Enter {jobRole}'s Birthday (MM/DD/YYYY):");
            }
            DateOnly bday = new DateOnly(Int32.Parse(stringBday.Substring(6, 4)), Int32.Parse(stringBday.Substring(0, 2)), Int32.Parse(stringBday.Substring(3, 2)));
            string stringHireDate = AnsiConsole.Ask<string>($"Enter {jobRole}'s Hire Date (MM/DD/YYYY):");
            while (Worker.IsValidDate(stringHireDate) == false)
            {
                AnsiConsole.WriteLine("Incorrect format specified, please enter the hire date in the following format: MM/DD/YYY");
                stringHireDate = AnsiConsole.Ask<string>($"Enter {jobRole}'s hire date (MM/DD/YYYY):");
            }
            DateOnly hiredate = new DateOnly(Int32.Parse(stringHireDate.Substring(6, 4)), Int32.Parse(stringHireDate.Substring(0, 2)), Int32.Parse(stringHireDate.Substring(3, 2)));
            double? rate = AnsiConsole.Ask<double>($"Enter {jobRole}'s rate: ");
            int emId = workerList.Count + 1;
            switch (jobRole)
            {
                case "Employee":
                    workerList.Add(new Employee(first, last, emAge, bday, rate, emId: emId, hiredate, jobRole));
                    break;
                case "Manager":
                    workerList.Add(new Manager(first, last, emAge, bday, rate, emId: emId, hiredate));
                    break;
                case "Researcher":
                    workerList.Add(new Researcher(first, last, emAge, bday, rate, emId: emId, hiredate));
                    break;
                default:
                    break;
            }
            
            int indexId = emId - 1;
            workerList[index: indexId].DisplayEmployeeDetails();
            AnsiConsole.Write($"New {jobRole} sucessfully added!");
            Console.ReadKey(true);
            //AnsiConsole.Ask<string>($"New {jobRole} sucessfully added!");

        }
        public static void HireEmployee(List<IWorker> workerList)
        {
            if (workerList is null)
            {
                throw new ArgumentNullException(nameof(workerList));
            }

            string first = AnsiConsole.Ask<string>("Enter Employee's First Name:");
            while (Worker.IsValidFirstName(first) == false)
            {
                AnsiConsole.WriteLine("Please enter a valid first name for the employee");
                first = AnsiConsole.Ask<string>("Enter Employee's First Name:");
            }
            string last = AnsiConsole.Ask<string>("Enter Employee's Last Name:");
            while (Worker.IsValidLastName(last) == false)
            {
                AnsiConsole.WriteLine("Please enter a valid last name for the employee");
                last = AnsiConsole.Ask<string>("Enter Employee's Last Name:");
            }
            int emAge = AnsiConsole.Ask<int>("Enter Employee's Age:");
            while (Worker.IsValidateAge(emAge) == false)
            {
                AnsiConsole.WriteLine("Incorrect format specified, please enter the birthday in the following format: MM/DD/YYY");
                emAge = AnsiConsole.Ask<int>("Please enter a valid age for the employee:");
            }
            string stringBday = AnsiConsole.Ask<string>("Enter Employee's Birthday (MM/DD/YYYY):");
            while (Worker.IsValidDate(stringBday) == false)
            {
                AnsiConsole.WriteLine("Incorrect format specified, please enter the birthday in the following format: MM/DD/YYY");
                stringBday = AnsiConsole.Ask<string>("Enter Employee's Birthday (MM/DD/YYYY):");
            }
            DateOnly bday = new DateOnly(Int32.Parse(stringBday.Substring(6, 4)), Int32.Parse(stringBday.Substring(0, 2)), Int32.Parse(stringBday.Substring(3, 2)));
            string stringHireDate = AnsiConsole.Ask<string>("Enter Employee's Hire Date (MM/DD/YYYY):");
            while (Worker.IsValidDate(stringHireDate) == false)
            {
                AnsiConsole.WriteLine("Incorrect format specified, please enter the hire date in the following format: MM/DD/YYY");
                stringHireDate = AnsiConsole.Ask<string>("Enter Employee's hire date (MM/DD/YYYY):");
            }
            DateOnly hiredate = new DateOnly(Int32.Parse(stringHireDate.Substring(6, 4)), Int32.Parse(stringHireDate.Substring(0, 2)), Int32.Parse(stringHireDate.Substring(3, 2)));
            double? rate = AnsiConsole.Ask<double>("Enter Employee's rate: ");
            int emId = workerList.Count + 1;
            workerList.Add(new Employee(first, last, emAge, bday, rate, emId: emId, hiredate));
            int indexId = emId - 1;
            workerList[index: indexId].DisplayEmployeeDetails();
            AnsiConsole.Ask<string>("New Employee sucessfully added!");
        }

        public static void HireManager(List<Worker> workerList)
        {
            if (workerList is null)
            {
                throw new ArgumentNullException(nameof(workerList));
            }

            string first = AnsiConsole.Ask<string>("Enter Manager's First Name:");
            while (Worker.IsValidFirstName(first) == false)
            {
                AnsiConsole.WriteLine("Please enter a valid first name for the Manager");
                first = AnsiConsole.Ask<string>("Enter Manager's First Name:");
            }
            string last = AnsiConsole.Ask<string>("Enter Manager's Last Name:");
            while (Worker.IsValidLastName(last) == false)
            {
                AnsiConsole.WriteLine("Please enter a valid last name for the Manager");
                last = AnsiConsole.Ask<string>("Enter Manager's Last Name:");
            }
            int emAge = AnsiConsole.Ask<int>("Enter Manager's Age:");
            while (Worker.IsValidateAge(emAge) == false)
            {
                AnsiConsole.WriteLine("Incorrect format specified, please enter the birthday in the following format: MM/DD/YYY");
                emAge = AnsiConsole.Ask<int>("Please enter a valid age for the Manager:");
            }
            string stringBday = AnsiConsole.Ask<string>("Enter Manager's Birthday (MM/DD/YYYY):");
            while (Worker.IsValidDate(stringBday) == false)
            {
                AnsiConsole.WriteLine("Incorrect format specified, please enter the birthday in the following format: MM/DD/YYY");
                stringBday = AnsiConsole.Ask<string>("Enter Manager's Birthday (MM/DD/YYYY):");
            }
            DateOnly bday = new DateOnly(Int32.Parse(stringBday.Substring(6, 4)), Int32.Parse(stringBday.Substring(0, 2)), Int32.Parse(stringBday.Substring(3, 2)));
            string stringHireDate = AnsiConsole.Ask<string>("Enter Manager's Hire Date (MM/DD/YYYY):");
            while (Worker.IsValidDate(stringHireDate) == false)
            {
                AnsiConsole.WriteLine("Incorrect format specified, please enter the hire date in the following format: MM/DD/YYY");
                stringHireDate = AnsiConsole.Ask<string>("Enter Employee's hire date (MM/DD/YYYY):");
            }
            DateOnly hiredate = new DateOnly(Int32.Parse(stringBday.Substring(6, 4)), Int32.Parse(stringBday.Substring(0, 2)), Int32.Parse(stringBday.Substring(3, 2)));
            double? rate = AnsiConsole.Ask<double>("Enter Manager's hourly rate: ");
            int emId = workerList.Count + 1;
            workerList.Add(new Manager(first, last, emAge, bday, rate, emId: emId, hiredate));
            int indexId = emId - 1;
            workerList[index: indexId].DisplayEmployeeDetails();
            AnsiConsole.Ask<string>($"Manager {first} {last} sucessfully added!");
        }

        public static void HireResearcher(List<Worker> workerList)
        {
            if (workerList is null)
            {
                throw new ArgumentNullException(nameof(workerList));
            }

            string first = AnsiConsole.Ask<string>("Enter Researcher's First Name:");
            while (Worker.IsValidFirstName(first) == false)
            {
                AnsiConsole.WriteLine("Please enter a valid first name for the Researcher");
                first = AnsiConsole.Ask<string>("Enter Researcher's First Name:");
            }
            string last = AnsiConsole.Ask<string>("Enter Researcher's Last Name:");
            while (Worker.IsValidLastName(last) == false)
            {
                AnsiConsole.WriteLine("Please enter a valid last name for the Researcher");
                last = AnsiConsole.Ask<string>("Enter Researcher's Last Name:");
            }
            int emAge = AnsiConsole.Ask<int>("Enter Researcher's Age:");
            while (Worker.IsValidateAge(emAge) == false)
            {
                AnsiConsole.WriteLine("Incorrect format specified, please enter the birthday in the following format: MM/DD/YYY");
                emAge = AnsiConsole.Ask<int>("Please enter a valid age for the Researcher:");
            }
            string stringBday = AnsiConsole.Ask<string>("Enter Researcher's Birthday (MM/DD/YYYY):");
            while (Worker.IsValidDate(stringBday) == false)
            {
                AnsiConsole.WriteLine("Incorrect format specified, please enter the birthday in the following format: MM/DD/YYY");
                stringBday = AnsiConsole.Ask<string>("Enter Researcher's Birthday (MM/DD/YYYY):");
            }
            DateOnly bday = new DateOnly(Int32.Parse(stringBday.Substring(6, 4)), Int32.Parse(stringBday.Substring(0, 2)), Int32.Parse(stringBday.Substring(3, 2)));
            string stringHireDate = AnsiConsole.Ask<string>("Enter Researcher's Hire Date (MM/DD/YYYY):");
            while (Worker.IsValidDate(stringHireDate) == false)
            {
                AnsiConsole.WriteLine("Incorrect format specified, please enter the hire date in the following format: MM/DD/YYY");
                stringHireDate = AnsiConsole.Ask<string>("Enter Researcher's hire date (MM/DD/YYYY):");
            }
            DateOnly hiredate = new DateOnly(Int32.Parse(stringBday.Substring(6, 4)), Int32.Parse(stringBday.Substring(0, 2)), Int32.Parse(stringBday.Substring(3, 2)));
            double? rate = AnsiConsole.Ask<double>("Enter Researcher's rate: ");
            int emId = workerList.Count + 1;
            workerList.Add(new Manager(first, last, emAge, bday, rate, emId: emId, hiredate));
            int indexId = emId - 1;
            workerList[index: indexId].DisplayEmployeeDetails();
            AnsiConsole.Ask<string>($"New Researcher: {first} {last} sucessfully added!");
        }
    }


}
