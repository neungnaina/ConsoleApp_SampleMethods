using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_SampleMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program ObjProg = new Program();
            ObjProg.SampleMethod();// Call object method
            SampleMethod01(); // Call Static Methods
        }
        public void SampleMethod()
        {
            Console.WriteLine("Capybara");
            Console.ReadKey();
        }
        static void SampleMethod01()
        {
            Console.WriteLine("Capybara");
            Console.ReadKey();
        }
    }
}
