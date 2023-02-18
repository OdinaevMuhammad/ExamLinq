
using Task6.Dtos;

List<Employee> employees = new List<Employee>
{

    new Employee { Name = "Alice", Department = "Sales", Salary = 50000},
    new Employee { Name = "Bob", Department = "IT", Salary = 60000 },
    new Employee { Name = "Charlie", Department = "Sales", Salary = 55000 },
    new Employee { Name = "Dave", Department = "IT", Salary = 65000 },
    new Employee { Name = "Eve", Department = "HR", Salary = 45000 }
};

var list = (from e in employees 
            group e by e.Department into g 
            select new
            {
                
                Department = g.Key,
                Salary = g.Average(x=> x.Salary)
            }).ToList();

foreach (var item in list)
{
    System.Console.WriteLine(item);
   
}
