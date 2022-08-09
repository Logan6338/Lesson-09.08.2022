int number = new Random().Next(100, 1000);

void find()
{
    Console.WriteLine(number);
    Console.WriteLine();
    Console.Write(number / 100);
    Console.Write(number % 10);
}

find();
