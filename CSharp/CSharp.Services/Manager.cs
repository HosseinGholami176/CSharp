using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Models;
namespace CSharp.Services
{
    public class Manager<T , R>
    {

        private T[] list = new T[1000];
        private int index = 0;

        public virtual void Add(T t)
        {
            list[index++] = t;

        }

        public int GetCount { get { return index; } }

    }

    public class ListManager : Manager<Product , int>
    {
        public override void Add(Product t)
        {
            base.Add(t);
        }
    }
}
