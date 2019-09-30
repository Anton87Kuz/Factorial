using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial.Factorial
{
    public class Data
    {
        private int _value { get; set; }

        public Data(int value)
        {
            _value = value;
        }

        public int GetValue()
        {
            return _value;
        }

        public int MultOnInt(int mult, int prev)
        {
            
            var temp = _value * mult + prev;
            _value = temp % 100;
            return (temp / 100);
        }

        


        public void Display(bool flag)
        {
            if (_value < 10)
            {
                if (flag) { Console.Write(_value); }
                else { Console.Write($"0{_value}"); }
            }
            else
            {
                Console.Write(_value);
            }
        }
    }
}
