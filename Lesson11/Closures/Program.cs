using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closures
{
    class Program
    {
        private class _AnonimousClass
        {
            public float sum;
            public int inc;
            public float _AnonimousMethod(int var1)
            {
                inc++;
                sum += var1;
                return sum/inc;
            }
        }

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 4, 6, 10 };

            var sum = GetAFunc();
            foreach(int number in numbers)
            {
                Console.WriteLine(sum(number));
            }
            

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        public static Func<int,float> GetAFunc()
        {
            var _anonimousClass = new _AnonimousClass();
            _anonimousClass.sum = 0;
            return _anonimousClass._AnonimousMethod;

        }
    }
}
