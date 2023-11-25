namespace LastTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа через клавишу Enter");
            int a = Int32.Parse(Console.ReadLine());
            bool b1 = Convert.ToBoolean(a);
            int b = Int32.Parse(Console.ReadLine());
            bool b2 = Convert.ToBoolean(b);
            int c = Int32.Parse(Console.ReadLine());
            bool b3 = Convert.ToBoolean(c);
            Console.WriteLine($"Среднее арифметическое данных чисел: {(a + b + c)/3}");
        }
    }
}