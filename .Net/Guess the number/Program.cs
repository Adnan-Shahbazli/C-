int point = 0;
while (true)
{

    System.Console.WriteLine($"Point: {point}");
    if (point < 0)
    {
        System.Console.WriteLine("Game over");
        break;
    }
    Random rnd = new Random();
    int randomNumber = rnd.Next(100);
    for (int i = 1; i < 11; i++)
    {
        System.Console.WriteLine($"Attempt number {i} (There are 10 in total)");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        if (number > randomNumber) System.Console.WriteLine("Number <");
        else if (number < randomNumber) System.Console.WriteLine("Number >");
        else if (number == randomNumber && i > 1)
        {
            System.Console.WriteLine("You guessed right");
            point += 1;
            break;
        }
        else if (number == randomNumber && i == 1)
        {
            System.Console.WriteLine("You guessed right");
            point += 10;
            break;
        }
        else if (number != randomNumber) point -= 10;
    }
    Thread.Sleep(2000);
    Console.Clear();
}
    