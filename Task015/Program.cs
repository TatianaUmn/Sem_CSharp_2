Console.WriteLine("Введите число от 1 до 7 включительно: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number == 6 || number == 7)
{
    Console.WriteLine("Да, день является выходным");
}
else if (number < 1 || number > 7)
    {
        Console.WriteLine("Вы ввели неправильное число");
    }
else
{
    Console.WriteLine("Нет, этот день не выходной");
}