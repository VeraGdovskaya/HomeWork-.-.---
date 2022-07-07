// //*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Imput number A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Imput number B: ");
// int B = Convert.ToInt32(Console.ReadLine());

// int C = A;

// for (int i = 1; i < B; i++)
// {   
//      C = C * A;
// }

// Console.WriteLine($" {A} , {B}  -> {C}");


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Imput number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write(number + " -> ");

// int sum = 0;

// while ( number > 0 )
// {
//   int k = number % 10;
//   number = number / 10;
//   sum = sum + k;
// }
// Console.WriteLine(sum);


// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] numbers = new int[8];


for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0 , 100 );
    Console.Write(numbers[i] + " , ");
 }

Console.Write(" ->");

