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


            result = Sum(1, 3,3);


            MessageBox.Show(result.ToString());

        }



        int Sum(int num1 ,ref int num2 , int num3 = 0 ,int num4 = 10)
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

            int count = 5;

            Product.Add(count);


        }
    }
}
