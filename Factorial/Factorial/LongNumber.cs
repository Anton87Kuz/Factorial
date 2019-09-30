using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial.Factorial
{
    public class LongNumber
    {
        private List<Data> _value = new List<Data>();

        public LongNumber(int n)
        {
            do
            {
                _value.Add(new Data(n%100));
                n /= 100;
            }
            while (n!=0);
        }

        public int NumberOfDigits()
        {
            int temp;
            if (_value[_value.Count - 1].GetValue() < 10)
            {
                temp = 1;
            }
            else
            {
                temp = 2;
            }
            return 2*(_value.Count-1)+temp;
        }

        public void MultOnInt(int n)
        {
            int least = 1, prev = 0;
            for (int i = 0; i < _value.Count; i++)
            {
                least = _value[i].MultOnInt(n, prev);
                prev = least;
            }
            while (least != 0) 
            {
                _value.Add(new Data(least % 100));
                least /= 100;
            }
        }

        public void Display()
        {
            _value[_value.Count - 1].Display(true);
            for (int i = _value.Count - 2; i >= 0; i--)
            {
               _value[i].Display(false);
            }
        }






    }
}
