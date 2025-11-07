using CsRepeat.Models;
using CsRepeat.Services;

namespace CsRepeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompanyService companyService = new CompanyService();
            companyService.AddWorker(new Manager("Revan", 21, 82163, "asdsa",20));
        }
    }
}
