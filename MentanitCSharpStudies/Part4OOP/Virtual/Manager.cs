using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4OOP.Virtual
{
    public class Manager : Employee
    {
        public override int Bonus
        {
            get => base.Bonus;
            set { if (value > 10 && value < 100) base.Bonus = value; }
        }

        public override void GetSalary()
        {
            Console.WriteLine("Manager's salary is $100");
        }
    }
}
