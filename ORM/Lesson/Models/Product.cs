namespace Lesson.Models
{
    public class Product
    {
        public int id;
        public string name;
        public double money;

        public override string ToString()
        {
            return $"[Id] = {id}, [Name] = {name}, [Money] = {money}";
        }
    } 
}