// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.Write("input first number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input second number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

int max = number_1;

if ( number_1 > number_2 )   
    Console.WriteLine("a = " + number_1 + ", b = " + number_2 + " -> max = " + number_1 + "");
else
    Console.WriteLine("a = " + number_1 + ", b = " + number_2 +" -> max = " + number_2 + "");

 