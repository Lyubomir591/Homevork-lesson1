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

//Задание 4
Console.WriteLine("Задание 2 ");
Console.WriteLine("Введите число до которого нужно просчитать ");
int numberUser = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите чило старт")
int numberCounter = Convert.ToInt32(Console.ReadLine()) ;
while (numberCounter <= numberUser)
{
    if(numberCounter % 2 == 0){
        Console.Write($"{numberCounter} ");
    }
   
    numberCounter++;
}
