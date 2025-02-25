using OOP.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entities
{
    public class ProEmployee : Employee
    {

        public override double Salary()
        {
            return
                BaseSalary * (1 + Level / 10) * TotalHours * 1 +
                BaseSalary * ExtraTime * (1 + Level / 10) * 1.2 * 1.5;
        }
    }
}
