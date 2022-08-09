Console.WriteLine("Введите первое число:");
int namberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int namberB = Convert.ToInt32(Console.ReadLine());

if (namberA > namberB)
{
    Console.WriteLine("Максимальное число равно");
    Console.WriteLine(namberA);
}
else
{
    Console.WriteLine("Максимальное число равно");
    Console.WriteLine(namberB);
}