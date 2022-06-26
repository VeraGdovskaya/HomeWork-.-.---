// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 2) 
    Console.WriteLine("a = " + number + " -> yes ");
else
    Console.WriteLine("a = " + number + " -> no ");

