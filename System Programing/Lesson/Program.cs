using System.Reflection;
using Lesson.Models;

Driver driver = new Driver("test", "Haas", null);

var info = typeof(Driver).GetMembers(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);

Console.WriteLine("{");
foreach (var item in info)
{

    if (item is PropertyInfo prop)
    {
        var value = prop.GetValue(driver);
        Console.WriteLine($"\t\"{prop.Name}\": \"{value ?? "null"}\"");
    }
    else if (item is FieldInfo field)
    {
        var value = field.GetValue(driver);
        Console.WriteLine($"\t\"{field.Name}\": \"{value ?? "null"}\"");
    }
}
Console.WriteLine("}");