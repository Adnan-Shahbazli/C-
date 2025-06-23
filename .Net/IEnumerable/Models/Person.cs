namespace IEnumerable.Models
{
    public enum Gender { male, female };
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Gender gender { get; set; }

        public Person(string name, string surname, Gender gender)
        {
            this.Name = name;
            this.Surname = surname;
            this.gender = gender;
        }
    }
}