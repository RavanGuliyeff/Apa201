using CsRepeat.Models.Common;

namespace CsRepeat.Models;

public class Worker : BaseEntity
{
    public string Name { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }
    public string Department { get; set; }

    public Worker(string name, int age, decimal salary, string department)
    {
        Name = name;
        Age = age;
        Salary = salary;
        Department = department;
    }

    public override string ToString()
    {
        return $"[{Id}] {Name} ({Age} yaş) | Salary: {Salary} | Dept: {Department} | Created: {CreatedAt}";
    }
}

