using System.Text;
Console.Clear();

object lockint = new object();
int num = 0;


_ = Task.Run(() =>
{
    for (int i = 0; i < 1_000_000; i++)
    {
        lock (lockint)
        {
            File.WriteAllText(@"C:\Users\shakh\Music\C#\C-\System Programing\Lesson\result.txt", (num++).ToString());
            // Thread.Sleep(100);
            // System.Console.WriteLine("Task 1");
        }
    }
}
);

_ = Task.Run(() =>
{
    for (int i = 0; i < 1_000_000; i++)
    {
        lock (lockint)
        {
            File.WriteAllText(@"C:\Users\shakh\Music\C#\C-\System Programing\Lesson\result.txt", (num++).ToString());
            // Thread.Sleep(100);
            // System.Console.WriteLine("Task 2");
        }
    }
}
);

_ = Task.Run(() =>
{
    for (int i = 0; i < 1_000_000; i++)
    {
        lock (lockint)
        {
            File.WriteAllText(@"C:\Users\shakh\Music\C#\C-\System Programing\Lesson\result.txt", (num++).ToString());
            // Thread.Sleep(100);
            // System.Console.WriteLine("Task 3");
        }
    }
}
);

System.Console.WriteLine("Enter any key");
Console.ReadKey();
System.Console.WriteLine(num);
