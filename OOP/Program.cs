using OOP;
using OOP.Abstraction;
using OOP.Factory;


#region Factories
IEmployeeFactory ceoFactory = new CEOFactory();
IEmployeeFactory proFactory = new ProEmployeeFactory();
IEmployeeFactory simpleFactory = new SimpleEmployeeFactory();
#endregion

#region Employee Objects
Employee ceo = ceoFactory.GetInstance("2426347392");
Employee pro = proFactory.GetInstance("2426347392");
Employee simple = simpleFactory.GetInstance("2426347392"); 
#endregion

ceo.FirstName = "ilia";
pro.FirstName = "ali";
simple.FirstName = "habib";

ceo.SetData(10, 4, 100, 20);
pro.SetData(10, 2, 100, 20);
simple.SetData(10, 1, 100, 20);

Console.WriteLine("CEO employee salary: " + ceo.Salary());
Console.WriteLine("Pro employee salary: " + pro.Salary());
Console.WriteLine("Simple employee salary: " + simple.Salary());

