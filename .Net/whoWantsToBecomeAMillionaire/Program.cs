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
void FiftyFifty(string rightanswer, string rigntSentence, string[] thisAnswer, ref bool isFiftyFifty)
{
    Console.Clear();
    if (!isFiftyFifty)
    {
        return;
    }
    System.Console.WriteLine("You've spent fifty on fifty.");
    Random random = new Random();
    int randomAnswer = random.Next(4) + 1;
    if (thisAnswer[randomAnswer] == rigntSentence)
    {
        randomAnswer++;
    }
    if (string.Compare(thisAnswer[randomAnswer], rigntSentence) > 0)
    {
        System.Console.WriteLine(rigntSentence);
        System.Console.WriteLine(thisAnswer[randomAnswer]);
    }
    else
    {
        System.Console.WriteLine(thisAnswer[randomAnswer]);
        System.Console.WriteLine(rigntSentence);
    }
    isFiftyFifty = false;
}
void AuditoriumHelp(string rightanswer, int index, ref bool isAuditoriumHelp)
{
    Console.Clear();
    if (!isAuditoriumHelp)
    {
        return;
    }
    System.Console.WriteLine("You've spent auditorium help.");
    index += 64;
    int remainsPercent = 100;
    int[] percent = new int[4];
    Random random = new Random();
    int randomPercent = random.Next(40, 65);
    remainsPercent -= randomPercent;
    percent[0] = randomPercent;

    for (int i = 1; i < 4; i++)
    {
        if (i == 3)
        {
            percent[i] = remainsPercent;
        }
        else
        {
            randomPercent = random.Next(0, remainsPercent);
            remainsPercent -= randomPercent;
            percent[i] = randomPercent;
        }
    }
    for (int i = 65, j = 1; i < 69; i++, j++)
    {
        if (i == index)
        {
            System.Console.WriteLine($"{Convert.ToChar(i)} - {percent[0]}");
            j--;
        }
        else
        {
            System.Console.WriteLine($"{Convert.ToChar(i)} - {percent[j]}");
        }
    }
    isAuditoriumHelp = false;
}
void FriendsHelp(string rightanswer, ref bool isFriendsHelp)
{
    Console.Clear();
    if (!isFriendsHelp)
    {
        return;
    }
    System.Console.WriteLine("You've spent friend's help.");
    Random random = new Random();
    int randomPercent = random.Next(1, 101);
    int randomTruePercent = random.Next(1, 21);
    System.Console.WriteLine("Your friend says");
    if (randomPercent >= randomTruePercent && randomPercent <= randomTruePercent + 79)
    {
        System.Console.WriteLine(rightanswer.ToUpper());
    }
    else
    {
        int randomFalse = random.Next(0, 3);
        if (randomFalse == 0)
        {
            if ("A" == rightanswer.ToUpper())
            {
                System.Console.WriteLine("B");
            }
            else
            {
                System.Console.WriteLine("A");
            }
        }
        else if (randomFalse == 1)
        {
            if ("B" == rightanswer.ToUpper())
            {
                System.Console.WriteLine("C");
            }
            else
            {
                System.Console.WriteLine("B");
            }
        }
        else
        {
            if ("C" == rightanswer.ToUpper())
            {
                System.Console.WriteLine("D");
            }
            else
            {
                System.Console.WriteLine("C");
            }
        }
    }
    isFriendsHelp = false;
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
    {"Who painted the Mona Lisa?","A:Pablo Picasso","B:Vincent van Gogh","C:Leonardo da Vinci","D:Michelangelo","C"}
};
int[] aSecondChance = new int[2] { 0, 0 };
RandomASecondChance(aSecondChance);
bool rightToMakeAMistake = true;
bool iswin = true;
bool isFiftyFifty = true;
bool isAuditoriumHelp = true;
bool isFriendsHelp = true;
int money = 0;
for (int i = 0; i < 10; i++)
{
    bool spelledСorrectly = true;
    while (spelledСorrectly)
    {
        for (int j = 0; j < 5; j++)
        {
            System.Console.WriteLine(questionAnswer[i, j]);
        }
        System.Console.Write("Enter your answer(A/B/C/D or 0 - Exit 1 - 50/50 2 - Auditorium help 3 - Friend's help):");
        string yourAnswer = Console.ReadLine();
        if (yourAnswer == "1" || yourAnswer == "2" || yourAnswer == "3")
        {
            int index = questionAnswer[i, 5].ToUpper()[0] - 64;
            if (yourAnswer == "1" && isFiftyFifty)
            {
                string[] thisAnswer = new string[6];
                for (int k = 0; k < 6; k++)
                {
                    thisAnswer[k] = questionAnswer[i, k];
                }
                FiftyFifty(questionAnswer[i, 5], questionAnswer[i, index], thisAnswer, ref isFiftyFifty);
            }
            else if (yourAnswer == "2")
            {
                AuditoriumHelp(questionAnswer[i, 5], index, ref isAuditoriumHelp);
            }
            else if (yourAnswer == "3")
            {
                FriendsHelp(questionAnswer[i, 5] ,ref isFriendsHelp);
            }
            else
            {
                System.Console.WriteLine("You don't have this clue.");
            }
        }
        else if (yourAnswer == "0")
        {
            break;
        }
        else if (yourAnswer.ToUpper() == "A" || yourAnswer.ToUpper() == "B" || yourAnswer.ToUpper() == "C" || yourAnswer.ToUpper() == "D")
        {
            spelledСorrectly = false;
            if (yourAnswer.ToUpper() == questionAnswer[i, 5].ToUpper())
            {
                money += 10000;
            }
            else if (yourAnswer.ToUpper() != questionAnswer[i, 5].ToUpper() && aSecondChance[0] != i && aSecondChance[1] != i && rightToMakeAMistake)
            {
                Console.Clear();
                System.Console.WriteLine("Your second chance has burned out!");
                System.Console.WriteLine($"You have saved {money}$.");
                rightToMakeAMistake = false;
            }
            else if (yourAnswer.ToUpper() != questionAnswer[i, 5].ToUpper() && aSecondChance[0] != i && aSecondChance[1] != i)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Game Over!");
                Console.ResetColor();
                iswin = false;
                break;
            }
        }
        else
        {
            System.Console.WriteLine("I don't understand your answer. Please write it again. After 2 seconds");
            Thread.Sleep(3000);
            Console.Clear();
        }

    }
    Thread.Sleep(3000);
    Console.Clear();
    if (!iswin)
    {
        System.Console.WriteLine($"You've lost {money}$ .");
        break;
    }
    else
    {
        System.Console.WriteLine($"You've won {money}$ .");
    }
}