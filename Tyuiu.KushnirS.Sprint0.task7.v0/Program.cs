using Tyuiu.KushnirS.Sprint0.task7.v0.lib;
namespace Tyuiu.KushnirS.Sprint0.task7.v0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "спринт 0 выполнил сергей к из ибксб-24-1";
            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива номер 1");
            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.Write(arrayNums1[i] + ", ");
            }
            Console.WriteLine();

            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива номер 1");
            for (int i = 0; i < arrayNums2.Length; i++)
            {
                Console.Write(arrayNums2[i] + ", ");
            }

            Console.WriteLine("РЕЗУЛЬТАТ    ");
            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);
                Console.WriteLine("сумма элементов массива равна ");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i] + ", ");
                }

            }
            else
            {
                Console.WriteLine("ошибка");
            }
            Console.ReadKey();
        }
    }
}
