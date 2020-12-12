using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInsert
{
    class Program
    {
     

        static void Main(string[] args)
        {
            ArrayIns ai;
            ai = new ArrayIns();

            ai.insert(88);
            ai.insert(92);
            ai.insert(77);
            ai.insert(74);
            ai.insert(32);
            ai.insert(80);
            ai.insert(95);
            ai.insert(85);

            ai.display();

            ai.insertionSort();
            ai.display();
            Console.ReadLine();

        }
        
      

   
    }
}
