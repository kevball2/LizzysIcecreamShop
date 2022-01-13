namespace LizzysIcecreamShop
{
    public class MenuScreen
    {
        public static string WelcomeScreen()
        {
            AnsiConsole.Clear();
            AnsiConsole.Write(new FigletText("Welcome to").Centered().Color(Color.Blue));
            AnsiConsole.Write(new FigletText("Lizzy's").Centered().Color(Color.Blue));
            AnsiConsole.Write(new FigletText("Ice Cream Shop").Centered().Color(Color.Blue));

            // prompt the user for the action they would like to complete.
            var option = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("What [green]action[/] would you like to perform?")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Move up and down to reveal more actions)[/]")
                    .AddChoices(new[] {
                    "HR tasks", "Inventory tasks", "Finance tasks",
                    "Research tasks", "Exit Application"
                    }));

            return option;
        }

        public static string HrScreen()
        {
            AnsiConsole.Clear();
            AnsiConsole.Write(new FigletText("Employee").Centered().Color(Color.Green));
            AnsiConsole.Write(new FigletText("Management").Centered().Color(Color.Green));

            // prompt the user for the action they would like to complete.
            var option = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("What [green]action[/] would you like to perform?")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Move up and down to reveal more actions)[/]")
                    .AddChoices(new[] {
                    "Hire Employee", "Hire Manager", "Hire Researcher",
                    "Give worker raise", "Give new title", "Remove worker", 
                    "Get worker details", "List all workers", "Return to Main Menu"
                    }));

            return option;
        }

        public static string FinanceScreen()
        {
            AnsiConsole.Clear();
            AnsiConsole.Write(new FigletText("Finance").Centered().Color(Color.Red));
            AnsiConsole.Write(new FigletText("Management").Centered().Color(Color.Red));

            // prompt the user for the action they would like to complete.
            var option = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("What [green]action[/] would you like to perform?")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Move up and down to reveal more actions)[/]")
                    .AddChoices(new[] {
                    "Pay Employee", "Refund Customer", "Buy Ice Cream",
                    "Return to Main Menu"
                    }));

            return option;
        }

        public static string InventoryScreen()
        {
            AnsiConsole.Clear();
            AnsiConsole.Write(new FigletText("Inventory").Centered().Color(Color.Yellow));
            AnsiConsole.Write(new FigletText("Management").Centered().Color(Color.Yellow));

            // prompt the user for the action they would like to complete.
            var option = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("What [green]action[/] would you like to perform?")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Move up and down to reveal more actions)[/]")
                    .AddChoices(new[] {
                    "Purchase Additional Ice Cream", "Purchase Waffle Cones", "Update Inventory",
                    "Return to Main Menu"
                    }));

            return option;
        }

        public static string ResearchScreen()
        {
            AnsiConsole.Clear();
            AnsiConsole.Write(new FigletText("Ice Cream").Centered().Color(Color.Orange1));
            AnsiConsole.Write(new FigletText("Research").Centered().Color(Color.Orange1));

            // prompt the user for the action they would like to complete.
            var option = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("What [green]action[/] would you like to perform?")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Move up and down to reveal more actions)[/]")
                    .AddChoices(new[] {
                    "Research new Ice Cream Flavor", "Retire Ice Cream", "Return to Main Menu"
                    }));

            return option;
        }
    }

}