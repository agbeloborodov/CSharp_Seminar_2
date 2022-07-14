internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        // z.B.:  645 -> 5
        // z.B.:  78 -> третьей цифры нет
        // z.B.:  32679 -> 6
        Console.Write("Введите любое число: ");
        string array_of_numbers = Console.ReadLine();
        if (array_of_numbers.Length < 3)
            Console.WriteLine("В введённом Вами числе нет третьей цифры");
        else
            Console.WriteLine("Третья цифра заданного числа: " + array_of_numbers[2]);
    }
}