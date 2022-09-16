// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Введите число A:");
int numberUserA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int numberUserB = Convert.ToInt32(Console.ReadLine());
int numbermax = 0;
int numbermin = 0;
if (numberUserA > numberUserB)
{
    numbermax = numberUserA;
    numbermin = numberUserB;
    Console.WriteLine($"Максимальное число: {numbermax}; Минимальное число: {numbermin}");

}
else
{
    numbermin = numberUserA;
    numbermax = numberUserB;
    Console.WriteLine($"Максимальное число: {numbermax}; Минимальное число: {numbermin}");
};
