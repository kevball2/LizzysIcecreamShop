using Spectre.Console;
using LizzysIcecreamShop.HR;
using LizzysIcecreamShop;

bool stop = true;
string option = MenuScreen.WelcomeScreen();
List<Employee> employees = new();


do 
{
   
    switch (option)
    {
        case "HR tasks":
            option = MenuScreen.HrScreen();
            switch(option)
            {
                case "Hire Manager":
                    string first = AnsiConsole.Ask<string>("Enter Employee's First Name:");
                    while(Employee.IsValidFirstName(first) == false)
                    {
                        AnsiConsole.WriteLine("Please enter a valid first name for the employee");
                        first = AnsiConsole.Ask<string>("Enter Employee's First Name:");
                    }
                    string last = AnsiConsole.Ask<string>("Enter Employee's Last Name:");
                    while (Employee.IsValidLastName(last) == false)
                    { 
                        AnsiConsole.WriteLine("Please enter a valid last name for the employee");
                        last = AnsiConsole.Ask<string>("Enter Employee's Last Name:");
                    }
                    int emAge = AnsiConsole.Ask<int>("Enter Employee's Age:");
                    while(Employee.IsValidateAge(emAge) == false)
                    {
                        AnsiConsole.WriteLine("Incorrect format specified, please enter the birthday in the following format: MM/DD/YYY");
                        emAge = AnsiConsole.Ask<int>("Please enter a valid age for the employee:");
                    }
                    string stringBday = AnsiConsole.Ask<string>("Enter Employee's Birthday (MM/DD/YYYY):");
                    while (Employee.IsValidBirthday(stringBday) == false)
                    {
                        AnsiConsole.WriteLine("Incorrect format specified, please enter the birthday in the following format: MM/DD/YYY");
                        stringBday = AnsiConsole.Ask<string>("Enter Employee's Birthday (MM/DD/YYYY):");
                    }
                    DateOnly bday = new DateOnly(Int32.Parse(stringBday.Substring(6, 4)), Int32.Parse(stringBday.Substring(0, 2)), Int32.Parse(stringBday.Substring(3, 2)));
                    double? rate = AnsiConsole.Ask<double>("Enter Employee's rate: ");
                    int emId = employees.Count + 1;
                    employees.Add(new Manager(first, last, emAge, bday, rate, emId: emId));
                    int indexId = emId - 1;
                    employees[index: indexId].DisplayEmployeeDetails();
                    AnsiConsole.Ask<string>("Did This work?");
                    break;
                default:
                    break;
            }
            break;
        case "Inventory tasks":
            option = MenuScreen.InventoryScreen();
            break;
        case "Finance tasks":
            option = MenuScreen.FinanceScreen();
            break;
        case "Research tasks":
            option = MenuScreen.ResearchScreen();
            break;
        case "Return to Main Menu":
            option = MenuScreen.WelcomeScreen();
            break;
        case "Exit Application":
            AnsiConsole.WriteLine("Exit Application");
            stop = false;
            break;
        default:
            option = MenuScreen.WelcomeScreen();
            break;
    }
    
}
while (stop);




//Console.WriteLine("Hello, World!");
