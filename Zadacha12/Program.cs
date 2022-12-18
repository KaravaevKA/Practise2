Console.Write($"Введите первое число: ");
int numFirst = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите второе число: ");
int numSecond = Convert.ToInt32(Console.ReadLine());

int div = numFirst % numSecond;

if (div == 0) {
    Console.WriteLine($"Кратно");
}
else {
    Console.WriteLine($"Не кратно. Остаток {div}");
}
