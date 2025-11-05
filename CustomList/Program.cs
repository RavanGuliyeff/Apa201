using ConsoleApp3.Models;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> ints = new CustomList<int>(1, 2, 3, 4, 5);
            ints.PrintAll();
        }
    }
}
