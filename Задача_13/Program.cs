// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.




void randomThirdnumber(){
int number = new Random().Next(0, 99999);
Console.Write(number + " ->");
if (number < 100) {
    Console.WriteLine("no third number");
}
if (number > 99 & number < 1000)
{
    Console.WriteLine(number % 100 % 10);
}
if (number > 999 & number < 10000)
{
    Console.WriteLine(number % 1000 % 100 / 10);  
}
if (number > 9999 & number < 100000)
{
   Console.WriteLine(number % 10000 % 1000 / 100);  
}
}

for (int i = 0; i <5; i++)
{
    randomThirdnumber();
}


