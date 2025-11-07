using CsRepeat.Models;

namespace CsRepeat.Services;

public class CompanyService
{
    private List<Worker> _workers = new List<Worker>();

    public void AddWorker(Worker worker)
    {
        _workers.Add(worker);
        Console.WriteLine($" {worker.Name} əlavə olundu.");
    }

    public void RemoveWorker(int id)
    {
        var worker = _workers.FirstOrDefault(x => x.Id == id);
        if (worker == null)
            Console.WriteLine(" Belə ID-li işçi yoxdur.");
        else
        {
            _workers.Remove(worker);
            Console.WriteLine($" {worker.Name} silindi.");
        }
    }

    public void ShowAll()
    {
        if (_workers.Count == 0)
        {
            Console.WriteLine(" Siyahı boşdur.");
            return;
        }

        Console.WriteLine("\n İşçilər:");
        foreach (var w in _workers)
            Console.WriteLine(w);
    }

    public void ShowAverageSalary()
    {
        if (_workers.Count == 0)
        {
            Console.WriteLine("Hesablamaq üçün işçi yoxdur.");
            return;
        }

        var avg = _workers.Average(x => x.Salary);
        Console.WriteLine($" Ortalama maaş: {avg:F2}");
    }
}
