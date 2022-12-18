Console.WriteLine("Введите число");

int Number = Convert.ToInt32(Console.ReadLine());

int a = Number % 10;
if (a % 10 < 0)
{
    Console.WriteLine("Третьей цифры нет");
}

else

{
    Console.WriteLine(a);
}