namespace Lesson.Models
{
    public class Human
    {
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public DateTime birthday { get; set; }

        public override string ToString()
        {
            return $"\"Firstname\": \"{firstName}\", \"lastName\": \"{lastName}\", \"birthday\": {birthday}";
        } 
    }
}