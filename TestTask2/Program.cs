using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTasks;

namespace TestTask2
{
    static class Program
    {
        static void Main(string[] args)
        {
            var result = Calculator.Calculate(new [] { 5, 3, -6, 7 });
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
