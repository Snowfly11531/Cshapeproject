using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    static class Extent {
        public static int myCount<T>(this IEnumerable<T> list) {
            int sum = 0;
            foreach (T i in list) {
                sum++;
            }
            return sum;
        }
    }
    class Mylist : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            yield return 1;
            yield return 2;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }

    class Mylist2 : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            yield return 1;
            yield return 2;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        private static void print<T>(IEnumerable<T> list) {
            foreach(T i in list) {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            var a = new { b = 1 };
            Mylist mylist = new Mylist();
            print(mylist);
            Console.ReadLine();
        }
    }
}
