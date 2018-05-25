using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharp.Models;
using CSharp.Services;
using CSharp.Utilities;
using System.Threading;

namespace CSharp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {

            Product product = new Product();


            int count = product.ToProduct();


            product.Count = 10;

            product.AddCount(3);

            product.AddCount(3333333333333333333);


            if (product.IsBuy)
                MessageBox.Show("به سبد خرید افزدوه شد");
            else
                MessageBox.Show("شما هیچ محصولی رو انتخاب نکرده اید");



            product.productbuyer[0] = new ProductBuyer()
            {
                Title = "Sony"
            };

            product.productbuyer[1] = new ProductBuyer()
            {
                Title = "Samsung"
            };



            ProductBuyer result = product["Sony1"];

            MessageBox.Show(result.Title);

        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {

            int a = 10;
            int b = 20;
            int c = 30;
            int d = 30;
            int result = 0;


            result = Sum(1, 3, 3);


            MessageBox.Show(result.ToString());

        }

        int Sum(int num1, ref int num2, int num3 = 0, int num4 = 10)
        {
            //num2 = 100;

            return num1 + num2 + num3 + num4;
        }

        int Sum(params int[] num)
        {
            int result = 0;

            foreach (var item in num)
            {
                result += item;
            }

            return result;
        }

        int Sum(string str, params int[] num)
        {
            int result = 0;

            foreach (var item in num)
            {
                result += item;
            }

            return result;
        }

        private void BtnAddProduct2_Click(object sender, EventArgs e)
        {

            Product product = new Product();

            product.RegisterDate = DateTime.Now;


        }

        private void BtnAddProduct3_Click(object sender, EventArgs e)
        {





            Manager<Product, int> product = new Manager<Product, int>();




            product.Add(new Product() { title = "test", Count = 20 });
            product.Add(new Product() { title = "test", Count = 20 });
            product.Add(new Product() { title = "test", Count = 20 });
            product.Add(new Product() { title = "test", Count = 20 });
            product.Add(new Product() { title = "test", Count = 20 });

            product.GetCount.ToString();


            Manager<User, int> user = new Manager<User, int>();

            user.Add(new User() { Id = 1, FirstName = "Hossein", LastName = "Gholami" });
            user.Add(new User() { Id = 1, FirstName = "Hossein", LastName = "Gholami" });
            user.Add(new User() { Id = 1, FirstName = "Hossein", LastName = "Gholami" });

            user.GetCount.ToString();

        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddlist_Click(object sender, EventArgs e)
        {

            try
            {
                NewMethod();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void NewMethod()
        {
            try
            {



                byte count = byte.Parse(TxtInput.Text);

                if (count > 20)
                    throw new MyException();

                string[] list = new string[count];

                for (int i = 0; i < count; i++)
                {
                    list[i] = "item" + i;
                }

                //string a = list[10];
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("طول ارایه به درستی وارد نشده است");
            }
            catch (FormatException)
            {
                MessageBox.Show("فرمت وارد شده صحیح نیست");
            }
            //catch (OverflowException ex)
            //{
            //    MessageBox.Show("بیشتر از 255 نمی توان وارد کرد");
            //    throw ex;
            //}
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {

            }
        }

        public class MyException : Exception
        {

            public MyException() : base("بیشتز از 255 می باشد")
            {

            }

            private const int MaxSize = 50;





        }

        private void BtnAddCount_Click(object sender, EventArgs e)
        {
            Customer foo = new Customer();
            //Product bar = new Product();
            //long count = foo + 10;


            //bool result = (foo == foo.Clone());

            Customer test = (Customer)foo.Clone();


            long count = foo;



            bool result = (foo == test);




        }

        private void BtnViweProduct_Click(object sender, EventArgs e)
        {

            Product foo = new Product();

            ViewProduct view = (ViewProduct)foo;

            view.Title = "Sony";
            view.Count = 40;


            List<string> list = new List<string>();


        }

        private void BtnToShamsi_Click(object sender, EventArgs e)
        {
            var date = DateTime.Now.ToShamsi();

            TxtInput2.Text = date;

        }

        private void BtnToString_Click(object sender, EventArgs e)
        {








            string.Join(",", 1, 2, 3, 5, 6, 7, 9, 10);

            TxtInput2.Text = String.Format(new System.Globalization.CultureInfo("fa-ir"), " جناب  آقای {0} خوش امدید", "علی");


            StringBuilder str = new StringBuilder();


            for (int i = 0; i < 1000000; i++)
            {
                str.Append("test" + i);
            }


            RichTxtList.Text = str.ToString();




        }

        private void BtnTherad_Click(object sender, EventArgs e)
        {


            List<Thread> list = new List<Thread>();

            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(MyThread);

                t.Start();
                list.Add(t);


            }

            foreach (var item in list)
            {
                item.Join();
            }







        }

        public void MyThread()
        {

            Thread.Sleep(1000);

            for (int i = 0; i < 10; i++)
                RichTxtList.Text += "test";


            RichTxtList.Text += "---------";
        }

        private void BtnTasking_Click(object sender, EventArgs e)
        {

            

         


        }

        private void BtnCalculator_Click(object sender, EventArgs e)
        {
            using(CalculatorServcies services = new CalculatorServcies())
            {
                Task t1 = services.Add();
                Task t2 = services.Calc();
                Task.WaitAll(t1, t2);

                TxtInput.Text = "Application Done";
            }
        }
    }
}
