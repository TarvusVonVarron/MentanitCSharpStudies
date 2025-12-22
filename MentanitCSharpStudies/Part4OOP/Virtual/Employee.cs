using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4OOP.Virtual
{
    public abstract class Employee
    {
        public virtual int Bonus { get; set; }
        public abstract void GetSalary();
    }
}
