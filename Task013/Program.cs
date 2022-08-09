Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str_number = number.ToString();
if(number > 99)
{
    Console.WriteLine("Третья цифра " + str_number[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}