// Задача 54: Задайте двумерный массив. Напишите программу, \
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

//  не выводится измененооый массив Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
//    at Program.<<Main>$>g__SortArray|0_2(Int32[,] array) in C:\Users\vgdovskaya\Desktop\HomeWork\18&20.07.22\Program.cs:line 56       
//    at Program.<Main>$(String[] args) in C:\Users\vgdovskaya\Desktop\HomeWork\18&20.07.22\Program.cs:line 22

// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns=Convert.ToInt32(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine("В итоге получается: ");

// SortArray(array);
// PrintArray(array);

// int[,] GetArray(int m, int n, int minValue, int maxValue) // создает двумерный массив
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
    
// }

// void PrintArray(int[,] inArray) // вывводит двумерный массив
// {
//     for (int row = 0; row < inArray.GetLength(0); row++)
//     {
//         for (int column = 0; column < inArray.GetLength(1); column++)
//         {
//             Console.Write($"{inArray[row,column]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void SortArray(int[,] array)
// {
//      for (int i = 0; i < array.GetLength(0); i++ ){
//         for (int j = 0; i < array.GetLength(1); j++){
//             for (int k = j+1; k < array.GetLength(1); k = k+1 ){
//                 if (array[i,k] > array[i,j]){
//                     int temp = array[i,j];
//                     array[i,j] = array[i,k];
//                     array[i,k] = temp;
//                 }
//             }
//         }
//      }
// }


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// int[,] GetArray(int m, int n, int minValue, int maxValue) 
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
    
// }

// void PrintArray(int[,] inArray) // вывводит двумерный массив
// {
//     for (int row = 0; row < inArray.GetLength(0); row++)
//     {
//         for (int column = 0; column < inArray.GetLength(1); column++)
//         {
//             Console.Write($"{inArray[row,column]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int GetRowNumber(int[,] array)
// {
//     int row = 0;
//     int minsum = 0;
//     for (int i = 0; i < array.GetLength(1); i++){
//         minsum = minsum + array[0,i];
//     }
//     for (int i = 1; i < array.GetLength(0); i++){
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++ ){
//             sum = sum + array[i,j];
//         }
//         if (minsum > sum)
//         {
//             minsum = sum;
//             row = i;
//         }
//     }
//     return row;
// }

// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns=Convert.ToInt32(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// Console.WriteLine($"Строка с наименьшей суммой - {GetRowNumber(array)}");


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

// int[,] GetArray(int m, int n, int minValue, int maxValue) // создает двумерный массив
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
    
// }
// void PrintArray(int[,] inArray) // вывводит двумерный массив
// {
//     for (int row = 0; row < inArray.GetLength(0); row++)
//     {
//         for (int column = 0; column < inArray.GetLength(1); column++)
//         {
//             Console.Write($"{inArray[row,column]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] GetMultimplicationMatrix(int[,] arrayA, int[,]arrayB)
// {
//     int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
//     for (int i = 0; i < arrayA.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayB.GetLength(1); j++)
//         {
//             for (int k = 0; k < arrayA.GetLength(1); k++)
//             {
//                 arrayC[i,j] += arrayA [i,k] * arrayB [k,j];
//             }
            
//         }
//     }
//     return arrayC; 
// }

// Console.Write("Введите количество строк 1 массива: ");
// int rowsA=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов 1 массива: ");
// int columnsA=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество строк 2 массива: ");
// int rowsB=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов 2 массива: ");
// int columnsB=Convert.ToInt32(Console.ReadLine());

// if (columnsA != rowsB)
// {
//     Console.WriteLine("Такие матрицы умножать нельзя");
// }

// int[,] A = GetArray(rowsA, columnsB, 0, 10);
// int[,] B = GetArray(rowsB, columnsB, 0, 10);
// PrintArray(A);
// Console.WriteLine();
// PrintArray(B);
// Console.WriteLine();
// PrintArray(GetMultimplicationMatrix(A, B)); 


//// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

// Ошибка в 234 строке, наверное в синтаксисе

Console.Write("введите размеры массива через пробел");
string[] nums = Console.ReadLine().Split("", StringSplitOptions.RemoveEmptyEntries);
int [,,] array = GetArray(new int[] {int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2])}, 10, 99);

PrintArray(array);

int [,,] GetArray(int[] sizes, int min, int max)
{
    int[,,] result = new int[sizes[0], sizes[1], sizes[2]];
    for (int i=0; i < result.GetLength(0); i++)
    {
        for (int j=0; j<result.GetLength(1); j++)
        {
            int k = 0;
            while(k<result.GetLength(2))
            {
                int element = new Random().Next(min, max+1);
                if (FindElement(result,element)) continue;
                result[i,j,k] = element;
                k++;
            }
        }
    }
    return result;
}

bool FindElement(int[,,] aray, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == el) return true;
            }
        }   
    }
    return false;
}

void PrintArray(int[,,] array);
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
              Console.Write($"{array[i,j,k]} ({i}, {j}, {k})  "); 
            }
            Console.WriteLine();
        }   
        Console.WriteLine();
    }
}

