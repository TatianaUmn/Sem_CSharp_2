Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= 100 && number < 1000)
{
    int digit = (number/10)%10;
    Console.WriteLine($"Вторая цифра числа {number} равна {digit}");
}
else
{
    Console.WriteLine("Введенное число не трехзначное");
}