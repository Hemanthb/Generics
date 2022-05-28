using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PrintArray
{
    class PrintArray
    {
        public void ToPrintArray<T>(T[] values) 
        {
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }

    }
}
