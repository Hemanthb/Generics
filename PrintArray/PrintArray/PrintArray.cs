using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintArray
{
    class PrintArray
    {
        public void PrintIntArray(int[] intArray)
        {
            foreach (var item in intArray)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void PrintDoubleArray(double[] doubleArray)
        {
            foreach (var item in doubleArray)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void PrintCharArray(char[] charArray)
        {
            foreach (var item in charArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
