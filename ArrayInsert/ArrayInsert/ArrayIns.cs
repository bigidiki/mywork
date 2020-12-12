using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInsert
{
    class ArrayIns
    {

        private int nElems;
        private int[] a = new int[10];

        public void insertionSort()
        {
            int arrin;
            int arrout;
           int temp;

            for (arrout = 1; arrout < nElems; arrout++)
            {
               temp = a[arrout];
                arrin = arrout;
                
                while (arrin > 0 && a[arrin - 1] >= temp)
                {
                    a[arrin] = a[arrin - 1];
                    --arrin;
                }
                a[arrin] = temp;
               for(int i = 0; i < a.Length; i++)
                {
                    Console.Write(" {0} ",a[i]);
                }
                Console.WriteLine(" ");
            }

        }
        public void insert(int value)
        {
            a[nElems] = value;
            nElems++;
        }
        public  void display()
        {

            for (int j = 0; j < nElems; j++)
            {
                Console.Write(a[j] + " ");
            }
            Console.WriteLine(" ");
        }
    }
}
