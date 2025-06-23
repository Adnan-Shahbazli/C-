using IEnumerable.Models;

PhoneNumber phoneNumber = new PhoneNumber("asd", "a", Gender.female, "9940523333710");
System.Console.WriteLine(phoneNumber.Number);
System.Console.WriteLine(phoneNumber.person.gender);