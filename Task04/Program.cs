Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2 && number1 > number3)
{
    Console.WriteLine($"Число {number1} максимальное число");
}
else if (number2 > number1 && number2 > number3) Console.WriteLine($"Число {number2} максимальное число");
else if (number3 > number1 && number3 > number2) Console.WriteLine($"Число {number3} максимальное число");
