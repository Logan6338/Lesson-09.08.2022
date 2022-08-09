int number = GetMaxNumberRandomValue();

Console.WriteLine(number);

int GetMaxNumberRandomValue()
{

    int randomValue = new Random().Next(10, 100);

    Console.WriteLine(randomValue);

    int LastNumber = randomValue % 10;
    int FirstNumber = randomValue / 10;

    int max = LastNumber;
    if (LastNumber == FirstNumber)
    {
        Console.WriteLine("Числа равны");
    }
    else
    {

        if (max < FirstNumber)
        {
            max = FirstNumber;
        }
        Console.WriteLine($"max = {max}");
    }
       return new Random().Next(10, 100);
}

