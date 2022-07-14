internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
        Console.Write("Введите порядковый день недели (1-пн, 2-вт ... 7-вск): ");
        int number_of_day = int.Parse(Console.ReadLine());
        if (number_of_day > 7 ^ number_of_day < 0)
            Console.WriteLine("Вы ввели неправильное число");
        else if (number_of_day > 0 & number_of_day < 6)
            Console.WriteLine("Будний день " + number_of_day);
        else
            Console.WriteLine("Выходной " + number_of_day);
    }
}