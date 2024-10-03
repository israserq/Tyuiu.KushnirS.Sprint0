using System.Collections.Concurrent;
using Tyuiu.KushnirS.Sprint0.task6.v0.lib;
namespace Tyuiu.KushnirS.Sprint0.task6.v0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine(DataService.AdditionArray(numsArray));
            Console.WriteLine(DataService.MinusArray(numsArray));
            Console.WriteLine(DataService.MultArray(numsArray));
            Console.ReadKey();
        }
    }
}
