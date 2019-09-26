using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial.Factorial
{
    public class Data
    {
        private int _value=1;


        public int Set(int n, int prev)
        {
            
            var temp = _value * n + prev;
            _value = temp % 100;
            return (temp / 100);
        }


        public void Show(bool flag)
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
