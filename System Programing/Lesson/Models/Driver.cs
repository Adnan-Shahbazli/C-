namespace Lesson.Models
{
    public class Driver
    {
        public string fullName { get; set; }
        private string team { get; set; }
        public DateOnly? birthday;
        public static char driversLicense = 'A';

        public Driver(string fullName, string team, DateOnly? birthday)
        {
            this.fullName = fullName;
            this.team = team;
            if (birthday is not null)
            {
                this.birthday = birthday;
            }
            
        }
    }
}