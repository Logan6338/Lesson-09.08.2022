int number = Convert.ToInt32(Console.ReadLine());

void Delat()
{
    if ((number % 7 == 0) & (number % 23 == 0))
    {
        Console.WriteLine("Кратное");
    }
    else
    {
        Console.WriteLine("Не кратное");
    }
}

Delat();