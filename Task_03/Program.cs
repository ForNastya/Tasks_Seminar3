// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите любое число");
int n = int.Parse(Console.ReadLine());
int result = 0;
for (int i = 1; i<=n; i++)
{
    result += i;
}
Console.WriteLine(result);