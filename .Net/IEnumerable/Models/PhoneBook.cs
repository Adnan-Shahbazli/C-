using System.Collections;
using IEnumerable;
using IEnumerable.IEnumerators;

namespace IEnumerable.Models
{
    public class PhoneBook : IEnumerable<PhoneNumber>
    {
        public List<PhoneNumber> Numbers { get; set; }

        public PhoneBook(List<PhoneNumber> numbers)
        {
            this.Numbers = numbers;
        }

        public IEnumerator<PhoneNumber> GetEnumerator()
        {
            return new EnumeratorWithSortingByNumber(this.Numbers);
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    
}