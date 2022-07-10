// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end +1);
//     }
//     return RandomArray;
// }

// void ShowRandomArray(int[] array)
// {
//     Console.Write("[");
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//        if (array[i] % 2 == 0){
//         count ++;
//        }
//        Console.Write(array[i] + ",");
//     } 
//     Console.Write($"{"]"} {"->"} {count}");
// }

// Console.WriteLine("введите колличество элементов в массиве");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите первое число случайно генерируемого массива");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите последнее число случайно генерируемого массива");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(num, min, max);
// ShowRandomArray(myArray);







// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end +1);
//     }
//     return RandomArray;
// }

// void ShowRandomArray(int[] array)
// {
//    Console.Write("[");
//    int sum = 0;
//    for ( int i = 0; i < array.Length; i++){
//        if ( i % 2 != 0){
//         sum = sum + array[i];
//        }
//        Console.Write(array[i] + " , ");
//    }
//    Console.Write($"{"]"} {"->"} {sum}");
// }

// Console.WriteLine("введите колличество элементов в массиве");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите первое число случайно генерируемого массива");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите последнее число случайно генерируемого массива");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(num, min, max);
// ShowRandomArray(myArray);

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end +1);
//     }
//     return RandomArray;
// }

// void MyRandomArray(int[] array)
// {
//      Console.Write("[");
//     int max = array[0];
//     int min = array[0];
//      for (int i = 0; i < array.Length; i ++){
//         if (array[i] < min){
//         min = array[i];
//     }
//         else if (array[i] > max){
//         max = array[i];
//     }
//         Console.Write(array[i] + ",");
//     }  
//     Console.Write($"{"]"} {"->"} {max - min}");
// }

// Console.WriteLine("введите колличество элементов в массиве");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите первое число случайно генерируемого массива");
// int first = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите последнее число случайно генерируемого массива");
// int last = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(num, first, last);
// MyRandomArray(myArray);