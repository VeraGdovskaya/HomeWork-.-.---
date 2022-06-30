// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

void randomWeek(){
int number = new Random().Next(1, 7);
Console.Write(number + "->");
if (number > 6){
    Console.WriteLine("yes");
}
else {
    Console.WriteLine("no");
}
}

randomWeek();