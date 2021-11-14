bool stop = true;
string option = MenuScreen.WelcomeScreen();
List<Worker> workers = new();


do 
{
   
    switch (option)
    {
        case "HR tasks":
            option = MenuScreen.HrScreen();
            switch(option)
            {
                case "Hire Employee":
                    helper.HireEmployee(workers);
                    break;
                case "Hire Manager":
                    helper.HireManager(workers);
                    break;
                case "Hire Researcher":
                    helper.HireResearcher(workers);
                    break;
                case "List all workers":
                    Worker.DisplayAllEmployeesDetails(workers);
                    break;
                case "Get worker details":
                    Worker.DisplaySelectedEmployeeDetails(workers);
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
