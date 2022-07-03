// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
Console.Write(number + " ->");

if (number[0] == number[4] || number[1] == number[3]){
    Console.WriteLine("yes");
}
else {
   Console.WriteLine("no");
}


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату x1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y2");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z1");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z2");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Sqrt((x1 - x2)*(x1 - x2)+(y1 - y2)*(y1 - y2)+(z1-z2)*(z1-z2)));

// задача 21 с методом

double newInterval(int x1, int x2, int y1, int y2, int z1, int z2){
return Math.Sqrt((x1 - x2)*(x1 - x2)+(y1 - y2)*(y1 - y2)+(z1-z2)*(z1-z2));
}

Console.WriteLine("Введите координату x1");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x2");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y1");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y2");
int By = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z1");
int Az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z2");
int Bz = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Round(newInterval(Ax, Ay, Bx, By, Az, Bz), 2));

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(number + " ->");

if (number >= 0)
{
    for (int current = 0; current <= number; current ++)
         Console.Write(current * current * current + " ");
} 
else 
{
    for (int current = 1; current > number; current --)
         Console.Write(current * current * current + " ");
} 
