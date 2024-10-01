using Tyuiu.KushnirS.Sprint0.task4.v0.lib;

namespace Tyuiu.KushnirS.Sprint0.task4.v0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1,5));
            Console.WriteLine(DataService.Minus(1, 5));
            Console.WriteLine(DataService.Del(5, 5));
            Console.WriteLine(DataService.Mult(1, 5));
            Console.ReadKey();
        }
    }
}
