using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("sizeof(int):{0}", sizeof(int));
            Console.WriteLine("sizeof(float):{0}", sizeof(float));
            Console.WriteLine("sizeof(char):{0}", sizeof(char));
            Console.WriteLine("sizeof(double):{0}", sizeof(double));
            Console.WriteLine("sizeof(bool):{0}", sizeof(bool));
            Console.WriteLine("sizeof(long):{0}", sizeof(long));
            Console.WriteLine("sizeof(uint):{0}", sizeof(uint));
            Console.WriteLine("sizeof(decimal):{0}", sizeof(decimal));
            Console.WriteLine("sizeof(byte):{0}", sizeof(byte));
            Console.WriteLine("the current date is :{0}",dt);
            dt.ToShortDateString();
            dt.ToShortTimeString();
          
        }
    }
}
