namespace IEnumerable.Models
{
    public class PhoneNumber
    {
        public Person person { get; set; }
        private string number;
        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value.Substring(0, 4) == "9940" && value.Length == 13)
                {
                    this.number = "+";
                    this.number += value;
                }
                else
                {
                    throw new Exception("Incorrect phone number");
                }
            }
        }

        public PhoneNumber(string name, string surname, Gender gender, string number)
        {
            this.person = new Person(name, surname, gender);
            this.Number = number;
        }
        public PhoneNumber(Person person, string number)
        {
            this.person = person;
            this.Number = number;
        }
    }
}