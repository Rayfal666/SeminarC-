Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"Число {number1} больше {number2} ");
}
else
{
    Console.WriteLine($"Число {number1} меньше {number2} ");
}
