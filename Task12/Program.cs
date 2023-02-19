// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

int multiDigit = MultiDigit(number1, number2);

if (multiDigit != 0)
    Console.WriteLine($"Число не четное,остаток от деления {multiDigit}");
else Console.WriteLine("Число четное");



int MultiDigit(int num1, int num2)
{
    // int result = (num1 % num2);
    return num1 % num2;
}