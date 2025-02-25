using OOP.Abstraction;
using OOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Factory
{
    internal class SimpleEmployeeFactory : IEmployeeFactory
    {
        public Employee GetInstance(string nationalCode) => new SimpleEmployee() { NationalCode = nationalCode };
    }
}
