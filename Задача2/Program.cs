// Программа, которая принимет два числа и выдает, максимальное и минимальное
Console.WriteLine("Введите число 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int b = Convert.ToInt32(Console.ReadLine());
int min = Math.Min(a, b);
int max = Math.Max(a, b);

Console.WriteLine("Минимум = " +min);
Console.WriteLine("Максимум = " +max);
