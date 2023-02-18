Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int lastNumber = number % 10;
    Console.Write($"Последня цыфра числа {number} - {lastNumber}");
}
else Console.WriteLine("Вы ввели НЕ трехзначное число");