// See https://aka.ms/new-console-template for more information
// Задание 1
Console.WriteLine("Задание 1");
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

//Задание 2
Console.WriteLine("Задание 2 ");
Console.WriteLine("Введите число до которого нужно просчитать ");
int numberUser = Convert.ToInt32(Console.ReadLine());
int numberCounter = 1;
while (numberCounter <= numberUser)
{
    Console.Write($"{numberCounter} ");
    numberCounter++;
}
