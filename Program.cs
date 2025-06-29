using System.Runtime.InteropServices;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estimate for carpet cleaning service") ;
            Console.Write("Number of small carpets:");
            int smallCarpets= Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of large carpets:");
            int largeCarpets= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price per small room: $25");
            Console.WriteLine("Price per large room: $35");
            int cost = Convert.ToInt32((smallCarpets * 25) + (largeCarpets * 35));
            Console.WriteLine($"cost:{cost}");
            double tax= Convert.ToDouble((cost*(6.0/100)));
            Console.WriteLine($"tax:{tax}");
            Console.WriteLine($"Total estimate:{cost+tax}");
            Console.WriteLine("This estimate is valid for 30 days");

        }
    }
}
