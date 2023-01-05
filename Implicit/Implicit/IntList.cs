using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit
{
    internal class IntList
    {

        private int[] arr;

        public IntList()
        {
            arr = new int[0];
        }

        public void Add(int str)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = str;
        }

        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

    }
}
