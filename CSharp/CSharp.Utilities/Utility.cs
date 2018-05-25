using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Utilities
{

    delegate int Add(int a, int b);

    public class Utility
    {
        public void Test()
        {
            Add a = Add;
            a(10,20);
        }



        public int Add(int a, int b)
        {
            return a + b;
        }

    }

     
}
