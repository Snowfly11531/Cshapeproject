using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
            IEnumerable<String> filePaths = Directory.GetFiles("D:/");
            filePaths.Count(p => p =="111");
            filePaths=filePaths.OrderBy(p => p.Length);
            Print(filePaths);
            var x=filePaths.Select(filepath =>
            {
                var fileInfo = new FileInfo(filepath);
                return new { fileInfo.Name, fileInfo.Length};
            });
            x = x.OrderBy(p => p.Length);
            var y=x.Select(s => {
                string unit = "B";
                float length = 0;
                if ((length = (float)s.Length / (float)1073741824) > 1) { unit = "GB"; }
                else if ((length = (float)s.Length / (float)1048576) > 1) { unit = "MB"; }
                else if ((length = (float)s.Length / (float)1024) > 1) { unit = "KB"; }
                else { length = s.Length; }
                return new { s.Name, Length = float.Parse(length.ToString("#0.00")) + unit };
            });
            print(y);
            Console.ReadLine();
        }
        static private void Print<T>(IEnumerable<T> item) {
            foreach(T i in items) {
                Console.WriteLine(i);
            }
        }
    }
}
