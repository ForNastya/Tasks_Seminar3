// Подсчитать сумму цифр в числе
Console.WriteLine("Введите любое число");
int number = int.Parse(Console.ReadLine());
int a = number / 100;
int b = number / 10 % 10;
int c = number % 10;
int sum = a + b + c;
Console.WriteLine("Сумма цифр числв = " + sum);