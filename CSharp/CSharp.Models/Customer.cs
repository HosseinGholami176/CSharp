using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Models
{
    public class Customer : EntityBase ,ICloneable
    {

        private long count;

        public long Count
        {
            get
            {
                return count;
            }
            set
            {
                if (value < 30)
                    count += value;
            }
        }

        protected static string Name = "";


        protected string Title;

        public void AddCustomer()
        {


        }

        public object Clone()
        {
            Customer customer = new Customer();
            customer.count = this.count;
            customer.Title = this.Title;

            return customer;
        }

        public override bool Equals(object obj)
        {
            Customer customer = (Customer)obj;

            return this.Title == customer.Title && this.count == customer.count;

        }

        public static long operator +(Customer a, int count)
        {
            return a.Count + count;
        }

        

        public static bool operator ==(Customer a , Customer b)
        {
            return a.Title == b.Title && a.Count == b.Count;

        }

        public static bool operator !=(Customer a, Customer b)
        {
            return !(a.Title != b.Title || a.Count != b.Count);

        }

        //public static explicit operator long(Customer a)
        //{
        //    return a.count;
        //}


        public static implicit operator long(Customer a)
        {
            return a.count;
        }
    }
}
