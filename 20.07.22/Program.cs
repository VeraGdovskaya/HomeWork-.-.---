// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Console.WriteLine("Введите натуральное число M:");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите натуральное число N:");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Сумма натуральных элементов в промежутке от M = {M}; до N= {N}; ->");

// void SumNumbers(int M, int N, int sum)
// {
//     if (M > N) 
//     {
//         Console.WriteLine($" {sum}"); 
//         return;
//     }
//     sum = sum + (M++);
//     SumNumbers(M, N, sum);
// }

// SumNumbers(M, N, 0);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

Console.Clear();
Console.WriteLine("Введите не отрицательное число m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите не отрицательное число n:");
int n = Convert.ToInt32(Console.ReadLine());

int functionAkkerman = Ack(m, n);
Console.Write($"m = {m}, n= {n}; -> A(m,n) = {functionAkkerman}");

int Ack(int m, int n)
{
    if (m == 0) return n+1;
    else if (m > 0 && n == 0) return Ack(m-1,1);
    else if (m >0 && n > 0) return Ack((m-1),(m, n-1));
}

