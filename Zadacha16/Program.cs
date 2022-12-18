Console.Write("Введите первое число");
int FirstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число");
int SecondNum = Convert.ToInt32(Console.ReadLine());

if ((FirstNum == SecondNum*SecondNum) | (SecondNum == FirstNum*FirstNum))
    Console.WriteLine("Является");
else 
    Console.WriteLine("Не является");
    
