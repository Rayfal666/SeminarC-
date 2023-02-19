int number = new Random().Next(100, 1000);
Console.WriteLine($"Cлучайное число из отрезка 100 - 999 => {number}");
int gluingDigit = GluingDigit(number);
Console.WriteLine(gluingDigit);
int GluingDigit(int num)
{
    // int firstDigit = num / 100 * 10;
    // int secondDigit = num % 10;
    // int result = firstDigit + secondDigit;
    // return result;
    int result = (num / 100 * 10) + (num % 10);
    return result;

}