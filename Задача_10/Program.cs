// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


void randomNumber(){
int number = new Random().Next(99, 1000);
Console.Write(number +" -> ");
Console.WriteLine(number % 100 /10);
}

randomNumber();
