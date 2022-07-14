// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] CreateRandomArray(int M, int first, int last)
// {
//     int[] RandomArray = new int[M];
//     for (int i = 0; i < M; i++)
//     {
//         RandomArray[i] = new Random().Next(first, last +1);
//     }
//     return RandomArray;
// }

// void MyRandomArray(int[] array)
// {
//     int positiv = 0;
//      for (int i = 0; i < array.Length; i ++){
//         if (array[i] > 0){
//         positiv ++;
//     }
//         Console.Write(array[i] + " , " );
//     }  
//     Console.Write($"{"->"} {positiv}");
// }

// Console.WriteLine("input M numbers from the keybord");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input first number");
// int first = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input last number");
// int last = Convert.ToInt32(Console.ReadLine());

// int[] MnumbersArray = CreateRandomArray(M, first, last);
// MyRandomArray(MnumbersArray);


// 43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.WriteLine("Введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение к2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}  -> ");

 if (k1 == k2)
{
       Console.Write("The lines are parallel");
}
else
{      
      Console.WriteLine($"{"("} {(b2-b1) / (k1-k2)}; {k1 * (b2-b1) / (k1-k2) + b1} {")"}"); 
}

