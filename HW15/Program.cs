// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//Ввод числа
Console.Write("Введите день недели: ");
int w = int.Parse(Console.ReadLine());

if (w > 0 & w < 6)
{
    Console.WriteLine("нет");
}
else if (w > 5 & w < 8)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("Вы ввели не день недели!");
}