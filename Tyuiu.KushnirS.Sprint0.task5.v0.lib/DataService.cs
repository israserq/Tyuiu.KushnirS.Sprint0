namespace Tyuiu.KushnirS.Sprint0.task5.v0.lib
{
    public class DataService
    {
        public static double Del(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine($"На {b} делить нельзя");
                return -1;
            }
            else
            { 
                return a / b;
            }
        }
    }
}
