using ConsoleApp23.Entities;
using System.Globalization;
using ConsoleApp23.Services;
namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            List<Resources> list = new List<Resources>();

            for (int i = 0; i < n; i++)
            {
                string[] strings = Console.ReadLine().Split(',');
                string name = strings[0];
                double value = double.Parse(strings[1], CultureInfo.InvariantCulture);
                list.Add(new Resources(name, value));
            }

            CalculationService calculationService = new CalculationService();

            Resources max = calculationService.Max(list);

            Console.WriteLine("Max: " + max);
        }
    }
}
