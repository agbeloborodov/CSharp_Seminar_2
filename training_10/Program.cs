internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
        int SecondDigit(int arg1)
        {
            int sec_dig = arg1 / 10 % 10;
            return sec_dig;
        }
        Console.Write("Введите трёхзначное число: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Вторая цифра введённого числа:  " + SecondDigit(a));
    }
}