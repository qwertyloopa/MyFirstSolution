namespace LastTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа через клавишу Enter");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Среднее арифметическое данных чисел: {(a + b + c)/3}");
            Console.ReadKey();
        }
    }
}