using System.Collections;
using IEnumerable.Models;

namespace IEnumerable.IEnumerators
{
    
    public class EnumeratorWithSortingByNumber : IEnumerator<PhoneNumber>
    {
        protected const int START_ITERATION_INDEX = -1;
        protected int Counter { get; set; }
        protected List<PhoneNumber> Numbers { get; set; }
        

        public PhoneNumber Current
        {
            get
            {
                return this.Numbers[this.Counter++];
            }
        }

        object IEnumerator.Current => Current;

        public EnumeratorWithSortingByNumber(List<PhoneNumber> Numbers)
        {
            this.Numbers = Numbers;
            this.Reset();
        }

        public bool MoveNext()
        {
            if(this.Counter == START_ITERATION_INDEX)
            {
                return true;
            }

            if (this.Numbers.Count <= this.Counter)
            {
                this.Reset();
                return false;
            }

            return true;
        }

        public void Reset()
        {
            this.Counter = START_ITERATION_INDEX;
        }

        public void Dispose()
        {
        }
    }
}