using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = new FibonacciSequence(10);
            foreach (var item in sequence)
                Console.WriteLine(item);
        }
    }
}
