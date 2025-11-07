namespace CsRepeat.Models;

public class Manager : Worker
{
    public int TeamSize { get; set; }

    public Manager(string name, int age, decimal salary, string department, int teamSize)
        : base(name, age, salary, department)
    {
        TeamSize = teamSize;
    }

    public override string ToString()
    {
        return base.ToString() + $" | Team Size: {TeamSize}";
    }
}
