Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число");
int numberB = Convert.ToInt32(Console.ReadLine());

void multiple()
{
    if ((numberA % numberB == 0) & (numberB % numberA ==0))
    {
        Console.WriteLine("Числа кратные");
    }
    else
    {
        Console.WriteLine($"Остаток - {numberA % numberB}!");
    }
}
multiple();