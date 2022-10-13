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
// Console.WriteLine("Hello, World!");

// int numbers = Convert.ToInt32(Console.ReadLine());
// string number = numbers.ToString();
// Console.WriteLine(number[1]);


// // Задача 2
// int a = Convert.ToInt32(Console.ReadLine());
// int b = 10;
// if (a >= 100 && a <= 1000)
// {
//     a %= b;
//     Console.Write(a);
// }
// else if (a > 1000)
// {
//     string numb = a.ToString();
//     Console.WriteLine(numb[2]);
// }
// else
// {
//     Console.WriteLine("Нет  третьей цифры");
// }
// // Задача 3

// int[] arrDay = { 1, 2, 3, 4, 5, 6, 7 };
// Console.WriteLine("Введите цифру обозначающую день недели");
// int nuberDeyUser = Convert.ToInt32(Console.ReadLine());
// bool day = false;
// if (nuberDeyUser == 6 || nuberDeyUser == 7)
// {
//     day = true;
// }

// foreach (var item in arrDay)
// {
//     if (item == nuberDeyUser)
//     {
//         if (day)
//         {
//             Console.WriteLine("Выходной день");
//         }
//         else
//         {
//             Console.WriteLine("Рабочий день");
//         }

//     }
// }
// // Задача 4
// int[] numbersArrUser = new int[8];

// for (int counter = 0; counter < numbersArrUser.Length; counter++)
// {
//     Console.WriteLine($"Введите {counter + 1}-е число");
//     numbersArrUser[counter] = Convert.ToInt32(Console.ReadLine());


// }
// int sum = 0;
// foreach (var item in numbersArrUser)
// {

//     sum = item + sum;

// }
// Console.WriteLine($"Средняя {sum / numbersArrUser.Length}");


//Урок 3 
//Задание №1

// Console.WriteLine("Введите полиндром :");
// int numberPOlendrom = Convert.ToInt32(Console.ReadLine());
// void Revers(int number)
// {
//     int copyNumber = number;
//     int result = 0;
//     while (number != 0)
//     {
//         int digit = number % 10;
//         result = result * 10 + digit;
//         number = number / 10;
//     }
//     if (result == copyNumber)
//     {
//         Console.WriteLine("Полиндром ");
//     }
//     else
//     {
//         Console.WriteLine("Не полиндром ");
//     }
// }
// Revers(numberPOlendrom);

// //  Задание № 3 
// Console.WriteLine("Введите число для подчета кубов ");
// int min = Convert.ToInt32(Console.ReadLine());

// void Cub(int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum = i * i * i;
//         Console.Write($"{sum} ");
//     }
// }
// Cub(min);
// // Задание 2 
// //Напишите метод, который принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double[][] Dablarr()
// {
//     double[][] mix = new double[2][];
//     mix[0] = new double[3];
//     mix[1] = new double[3];
//     int length = mix[0].Length;
//     for (int i = 0; i < length; i++)
//     {
//         Console.WriteLine("Введите координаты точки А");
//         mix[0][i] = Convert.ToInt32(Console.ReadLine());
//     }
//     for (int i = 0; i < length; i++)
//     {
//         Console.WriteLine("Введите координаты точки В");
//         mix[1][i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return mix;
// };

// double[][] arrT = Dablarr();


// void Function(double[][] arr)
// {
//     double sum = Math.Sqrt(Math.Pow(arr[1][0] - arr[0][0], 2) + Math.Pow(arr[1][1] - arr[0][1], 2) + Math.Pow(arr[1][2] - arr[0][2], 2));

//     Console.WriteLine(sum.ToString("F" + 2));
// }
// Function(arrT);






//____________________________________________________________________________________________________
//Урок 5
// Сщздать массив ;
// заполнить массив 
// Вывести массив 
// Вывести сколько эллементов находится в массиве  в диапазоне от 50 до 66

// int [] Create ( int letngth){
//     return new int [letngth];
// }

// void FillArray (int [] array, int min , int max){
//     int length = array.Length;
//     for (int i = 0; i < length; i++)
//     {
//         array[i]= new Random().Next(min, max);
//     }
// }

// string OutputArray (int [] array){
//     return "[" + String.Join(' ',array) + "]";
// }

// void Amount ( int [] array, int min , int max  ){
//     int length = array.Length;
//     int count = 0;
//     for (int i = 0; i < length; i++)
//     {
//         if(array[i]>= min && array[i]<= max){
//             count++;
//         }
//     }
//     Console.Write(count);
// }
// int [] array = Create(12);
// FillArray(array, 10, 99 );
// Console.WriteLine(OutputArray(array));
// Amount(array, 40 , 55 );


// ЗАдайте одомерный   массив , заполните случайными числами , Найдите сумму эллементов стоящих на нечетных позицыях

// int [] Create ( int length){
//     return new int[length];
// }
// void FillArray ( int [] array, int min, int max ){
//     int length = array.Length;
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(min,max);
//     }
// }
// string OutputArray(int [] array){
//     return "{" + String.Join(' ', array) + "}";
// }

// void SumArrayElement ( int [] array){
//     int length = array.Length;
//     int sum  = 0 ;
//     for (int i = 0; i < length; i++)
//     {
//         if(i % 2 > 0){
//             sum = sum + array[i-1];

//         }
//     }
//     Console.WriteLine(sum);
// }
// int [] array = Create(10);
// FillArray(array, 1, 10);
// Console.WriteLine(OutputArray(array));
// SumArrayElement(array);
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// int[] LengthArray(int numberLength)
// {
//     return new int[numberLength];
// }
// void FillArray(int[] array)
// {
//     int length = array.Length;
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(10, 20);
//     }
//     Console.WriteLine(String.Join(',', array));
// };
// void Difference(int[] array)
// {
//     int min = array.Min();
//     int max = array.Max();
//     int raz = max - min;
//     Console.WriteLine(raz);

// }
// int[] array = LengthArray(10);
// FillArray(array);
// Difference(array);
//___________________________________________________________________________________
//_______________________________________Урок4_______________________________________
//Shop
int[,] Random(int length, int enterVisiterTime, int exitVisiterTime)
{
    int[,] arr = new int[2, length];
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < length; j++)
        {
            arr[i, j] = new Random().Next(enterVisiterTime, exitVisiterTime + 1);

        }
    }
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < length; j++)
        {
            if (arr[0, j] > arr[1, j])
            {
                int temp = arr[0, j];
                arr[0, j] = arr[1, j];
                arr[1, j] = temp;
            }
            else if (arr[0, j] == arr[1, j])
            {
                arr[1, j] = arr[1, j]++;
            }
        }
    }
    return arr;
}
void OutputArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[] HourInterval(int column, int[,] arr)
{
    int leftEdge = arr[0, column];
    int rightEdge = arr[1, column];
    int length = rightEdge - leftEdge;
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = leftEdge;
        leftEdge++;
    }
    return result;
}
int[,] HoursMatrixAllCustomers(int customersTotal, int openingHour, int closingHour, int[,] inputArray)
{
    int[,] customersMatrix = new int[customersTotal, closingHour - openingHour + 1];
    for (int i = 0; i < customersMatrix.GetLength(0); i++)
    {
        int[] arrToFill = HourInterval(i, inputArray);
        for (int j = 0; j < arrToFill.Length; j++)
        {
            customersMatrix[i, arrToFill[j] - 8] = 1;
        }
    }
    return customersMatrix;
}

// вычисляем сумму единиц в каждом столбце
int SumInColumn(int column, int[,] matrix)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        sum = sum + matrix[j, column];
    }
    return sum;
}

// вычисляем часы, в которые в магазине находилось наибольшее количество посетителей
void MaxFilledHours(int[,] matrix)
{
    int[] sumVector = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sumVector[i] = SumInColumn(i, matrix);
    }
    int max = 0;
    for (int j = 0; j < sumVector.Length; j++) // находим максимальное число посетителей
    {
        if (sumVector[j] > max)
        {
            max = sumVector[j];
        }
    }
    for (int j = 0; j < sumVector.Length; j++) // повторяем цикл, чтобы найти все часы работы, в которые было достигнуто пиковое число посетителей
    {
        if (sumVector[j] >= max)
        {
            Console.WriteLine($"{j + 8}-{j + 9} => {max} человек");
        }
    }
}
int numberOfCustomers = 20;
int openingHour = 8;
int closingHour = 20;
Console.WriteLine();


int[,] random = Random(numberOfCustomers, openingHour, closingHour);
OutputArray(random);
int[,] testCustomerMatrix = HoursMatrixAllCustomers(numberOfCustomers, openingHour, closingHour, random);
MaxFilledHours(testCustomerMatrix);