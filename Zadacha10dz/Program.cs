Console.WriteLine("Введите число");

int Number = Convert.ToInt32(Console.ReadLine());

int a = Number / 10;
int b = a % 10;

Console.WriteLine(b);