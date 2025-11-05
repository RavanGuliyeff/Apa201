using ConsoleApp3.Models;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>( 1, 2, 3, 4, 5 );

            Console.WriteLine(list.Find(x => x == 6));
        }
    }
}
