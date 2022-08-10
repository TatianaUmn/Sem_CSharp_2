Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str_number = number.ToString();
if(number > 99 && number < 1000)
{
    Console.WriteLine("Вторая цифра " + str_number[1]);
}
else
{
    Console.WriteLine("Вы ввели неправильное число");
}
