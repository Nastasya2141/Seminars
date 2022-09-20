// Программа для нахождения максимального из трех введенных чисел
Console.WriteLine("Введите число 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > a)
    max = b;
if (c > max)
    max = c;

Console.WriteLine("Максимум = " +max);
