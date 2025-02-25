using OOP.Abstraction;
using OOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Factory
{
    public class CEOFactory : IEmployeeFactory
    {
        public Employee GetInstance(string nationalCode) => new CEO() { NationalCode = nationalCode};
        
    }
}
