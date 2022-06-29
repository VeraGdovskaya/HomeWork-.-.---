// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number = new Random().Next(0, 100000);
Console.Write(number + " ->");
if (number < 1000) {
    Console.WriteLine("no third number");
}
if (number > 999 & number < 10000)
{
    Console.WriteLine(number % 1000 % 100 / 10);
}
else {
    Console.WriteLine(number % 10000 % 1000 / 100);  
}

