
namespace SumCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введіть перше число:");
            if (!double.TryParse(Console.ReadLine(), out double number1))
            {
                Console.WriteLine("Помилка: потрібно ввести число!");
                return;
            }

            Console.WriteLine("Введіть друге число:");
            if (!double.TryParse(Console.ReadLine(), out double number2))
            {
                Console.WriteLine("Помилка: потрібно ввести число!");
                return;
            }

            double sum = number1 + number2;

            Console.WriteLine($"Сума чисел {number1} та {number2} дорівнює {sum}");
        }
    }
}