using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (
                int i = 0;
                i < 255; 
                i++)
            {
                Console.WriteLine($"i = {i} " + Convert.ToString(i,2));
                
            }
            Console.ReadLine();
        }
    }
}
