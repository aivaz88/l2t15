Console.Clear();

Console.Write("Введите положительное число: ");
int num = int.Parse(Console.ReadLine());

if (num > 0 && num < 6)
{
    Console.WriteLine("Нет");
}
else if (num > 5 && num < 8)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет такого дня недели");
}