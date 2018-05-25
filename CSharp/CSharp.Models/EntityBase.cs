using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Models
{
    public  class EntityBase
    {


        

      

        private int count;

        private string title;

        private int totalcount;

        public DateTime RegisterDate { get; set; }

        public virtual void AddDay()
        {
            this.RegisterDate = this.RegisterDate.AddDays(1);

        }



        public object CheckDynamic()
        {
            var foo = new
            {
                Title = "Car",
                Count = 10
            };
            return foo;
        }



        public void CheckDynamic2()
        {
            dynamic a = "adfadsfasdfasdf";

            a = new { Title = "Ali", Count = 10 };


            var b = a.Title;


            a = DateTime.Now;

            var day = a.Hour;


            




        }

        
      


    }
}
