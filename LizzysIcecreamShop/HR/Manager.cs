using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizzysIcecreamShop.HR
{
    internal class Manager: Employee
    {
        private int bonus;
        public const string employeeType = "Manager";
        public int Bonus { get => bonus; set => bonus = value; }

        public Manager(string first, string last, int emAge, DateOnly bday, double? rate, int emId) : base(first, last, emAge, bday, rate, emId)
        { }
    }
}
