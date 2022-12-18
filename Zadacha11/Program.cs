int number = new Random().Next(100,1000);

int firstNum = number/100;
int lastNum = number%10;

Console.WriteLine(number);
Console.WriteLine(firstNum*10+lastNum);