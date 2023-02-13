namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            try
            {
                Console.WriteLine("Введите первое число");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите третье число");
                c = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите четвертое число");
                d = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы ввели не число");
                return;
            }
            Console.WriteLine($"{a}");
            Console.WriteLine($"{b}");
            Console.WriteLine($"{c}");
            Console.WriteLine($"{d}");
        }
    }
}
