void RandomASecondChance(int[] aSecondChance)
{
    Random random = new Random();
    int firstRandomNumber = random.Next(10);
    aSecondChance[0] = firstRandomNumber;
    int secondRandomNumber = random.Next(10);
    while (secondRandomNumber == firstRandomNumber)
    {
        secondRandomNumber = random.Next(10);
    }
    aSecondChance[1] = secondRandomNumber;
}

string[,] questionAnswer = new string[10, 6]
{
    {"What is the capital city of France?","A:Berlin","B:Madrid","C:Paris","D:Rome","C"},
    {"Which planet is known as the Red Planet?","A:Earth","B:Mars","C:Jupiter","D:Venus","B"},
    {"Who wrote the play \"Romeo and Juliet\"?","A:Charles Dickens","B:William Shakespeare","C:Jane Austen","D:Mark Twain","B"},
    {"Which element has the chemical symbol 'O'?","A:Gold","B:Oxygen","C:Osmium","D:Iron","B"},
    {"In computing, what does \"CPU\" stand for?","A:Central Processing Unit","B:Computer Power Unit","C:Central Programming Utility","D:Core Performance Unit","A"},
    {"What is the largest ocean on Earth?","A:Atlantic Ocean","B:Indian Ocean","C:Arctic Ocean","D:Pacific Ocean","D"},
    {"Which country gave the Statue of Liberty to the United States?","A:France","B:England","C:Germany","D:Spain","A"},
    {"What is the hardest natural substance on Earth?","A:Gold","B:Iron","C:Diamond","D:Quartz","C"},
    {"How many continents are there on Earth?","A:Five","B:Six","C:Seven","D:Eight","C"},
    {"Who painted the Mona Lisa?","A:Pablo Picasso","B:Vincent van Gogh","C:Leonardo da Vinci","D:Michelangelo","c"}
};
int[] aSecondChance = new int[2] { 0, 0 };
RandomASecondChance(aSecondChance);
System.Console.WriteLine(aSecondChance[0]);
System.Console.WriteLine(aSecondChance[1]);

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 5; j++)
    {
        System.Console.WriteLine(questionAnswer[i, j]);
        
    }
    System.Console.Write("Enter your answer(A/B/C/D):");
        string yourAnswer = Console.ReadLine();
        if (Convert.ToString(char.ToUpper(Convert.ToChar(yourAnswer))) == questionAnswer[i, 5])
        {

        }
        else if (Convert.ToString(char.ToUpper(Convert.ToChar(yourAnswer))) != questionAnswer[i, 5] && aSecondChance[0] != i && aSecondChance[1] != i)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Game Over!");
            Console.ResetColor();
            break;
        }
        
    System.Console.WriteLine();
}