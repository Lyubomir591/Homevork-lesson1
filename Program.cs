// See https://aka.ms/new-console-template for more information
// // Задание 1
// Console.WriteLine("Задание 1");
// Console.WriteLine("Введите число A:");
// int numberUserA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B:");
// int numberUserB = Convert.ToInt32(Console.ReadLine());
// int numbermax = 0;
// int numbermin = 0;
// if (numberUserA > numberUserB)
// {
//     numbermax = numberUserA;
//     numbermin = numberUserB;
//     Console.WriteLine($"Максимальное число: {numbermax}; Минимальное число: {numbermin}");

// }
// else
// {
//     numbermin = numberUserA;
//     numbermax = numberUserB;
//     Console.WriteLine($"Максимальное число: {numbermax}; Минимальное число: {numbermin}");
// };

// //Задание 4
// Console.WriteLine("Задание 2 ");
// Console.WriteLine("Введите число до которого нужно просчитать ");
// int numberUser = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите чило старт");
// int numberCounter = Convert.ToInt32(Console.ReadLine()) ;
// while (numberCounter <= numberUser)
// {
//     if(numberCounter % 2 == 0){
//         Console.Write($"{numberCounter} ");
//     }

//     numberCounter++;
// }




// Homework Lessons2 

// Задача 1 
Console.WriteLine("Hello, World!");

int numbers = Convert.ToInt32(Console.ReadLine());
string number = numbers.ToString();
Console.WriteLine(number[1]);


// Задача 2
int a = Convert.ToInt32(Console.ReadLine());
int b = 10;
if (a >= 100 && a <= 1000)
{
    a %= b;
    Console.Write(a);
}
else if (a > 1000)
{
    string numb = a.ToString();
    Console.WriteLine(numb[2]);
}
else
{
    Console.WriteLine("Нет  третьей цифры");
}
// Задача 3

int[] arrDay = { 1, 2, 3, 4, 5, 6, 7 };
Console.WriteLine("Введите цифру обозначающую день недели");
int nuberDeyUser = Convert.ToInt32(Console.ReadLine());
bool day = false;
if (nuberDeyUser == 6 || nuberDeyUser == 7)
{
    day = true;
}

foreach (var item in arrDay)
{
    if (item == nuberDeyUser)
    {
        if (day)
        {
            Console.WriteLine("Выходной день");
        }
        else
        {
            Console.WriteLine("Рабочий день");
        }

    }
}
// Задача 4
int[] numbersArrUser = new int[8];

for (int counter = 0; counter < numbersArrUser.Length; counter++)
{
    Console.WriteLine($"Введите {counter + 1}-е число");
    numbersArrUser[counter] = Convert.ToInt32(Console.ReadLine());


}
int sum = 0;
foreach (var item in numbersArrUser)
{

    sum = item + sum;

}
Console.WriteLine($"Средняя {sum / numbersArrUser.Length}");
