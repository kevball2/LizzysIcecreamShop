using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizzysIcecreamShop.HR
{
    internal sealed class Manager: Worker
    {
        private int bonus;
        private const string employeeType = "Manager";
        public int Bonus { get => bonus; set => bonus = value; }

        public Manager(string first, string last, int emAge, DateOnly bday, double? rate, int emId, DateOnly emHireDate) : base(first, last, emAge, bday, rate, emId, employeeType, emHireDate)
        { }

        public Manager(string first, string last, int emAge, DateOnly bday, double? rate, int emId, DateOnly emHireDate, int emBonus) : base(first, last, emAge, bday, rate, emId, employeeType, emHireDate)
        { 
         Bonus = emBonus;
        }

        public override void DisplayEmployeeDetails()
        {
            AnsiConsole.WriteLine($"\nFirst Name: {FirstName}\nLast Name: {LastName}\nEmployee Id: {EmployeeId}\nEmployee Type: {employeeType}" +
                                  $"\nWage: {Wage}\nHire Date: {Hiredate}\nBonus: {Bonus}");
            AnsiConsole.Write("Press any key to continue");
            Console.ReadKey(true);
        }

    }
}
