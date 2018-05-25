using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharp.Models;
namespace CSharp.Utilities
{
    public static class ExtentionMethod
    {


        public static string ToShamsi(this DateTime date)
        {
            PersianCalendar PC = new PersianCalendar();
            string year = PC.GetYear(date).ToString();
            string month = PC.GetMonth(date).ToString();
            string day = PC.GetDayOfMonth(date).ToString();
            return year + "/" + month + "/" + day;
        }


        public static int ToProduct(this Product product)
        {
            return 10;
        }



        public static string ToSpace(this string text)
        {


            return text;
        }

    }
}
