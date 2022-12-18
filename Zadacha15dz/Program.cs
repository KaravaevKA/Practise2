Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());

if ((Number % 6 == 0) | (Number % 7 == 0))
{
    Console.WriteLine("Да, сегодня выходной");
}
else 
{
    Console.WriteLine("Эх, трудовые будни");
}
