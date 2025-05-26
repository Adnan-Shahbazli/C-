using System.Drawing;

void FillAllNameByUserInput(string[] names)
{
    for (int i = 0; i < names.Length; i++)
    {
        System.Console.Write($"Enter {i+1} name:");
        names[i] = Console.ReadLine();
    }
}
void ShowNamesArr(string[] names)
{
    for (int i = 0; i < names.Length; i++)
    {
        System.Console.WriteLine($"Index{i}:{names[i]}");
    }
}

string[] names = new string[10];
FillAllNameByUserInput(names);
ShowNamesArr(names);