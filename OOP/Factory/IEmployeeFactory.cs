using OOP.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Factory
{
    public interface IEmployeeFactory
    {
        Employee GetInstance(string nationalCode);
    }
}
