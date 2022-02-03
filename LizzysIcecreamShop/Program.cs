bool stop = true;
string option = MenuScreen.WelcomeScreen();
List<IWorker> workers = new();


do 
{
   
    switch (option)
    {
        case "HR tasks":
            option = MenuScreen.HrScreen();
            switch(option)
            {
                case "Hire Employee":
                    //helper.HireEmployee(workers);
                    helper.HireWorker(workers, "Employee");
                    break;
                case "Hire Manager":
                    //helper.HireManager(workers);
                    helper.HireWorker(workers, "Manager");
                    break;
                case "Hire Researcher":
                    //helper.HireResearcher(workers);
                    helper.HireWorker(workers, "Researcher");
                    break;
                case "List all workers":
                    Worker.DisplayAllEmployeesDetails(workers);
                    break;
                case "Get worker details":
                    Worker.DisplaySelectedEmployeeDetails(workers);
                    break;
                case "Give worker raise":
                    Worker.GiveWorkerRaise(workers);
                    break;
                case "Give worker new title":
                    Manager.UpdateWorkerTitle(workers);
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
