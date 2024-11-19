using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace ExampleCode
{
    internal class Program //internal: giới hạn truy cập
    {
        static void Main(string[] args)
        {
            DateTime Now = DateTime.Now;
            Console.WriteLine("Hello World!" + " " + Now);

            //Khai bao bien
            VariableDeclaration();

            //Dien tich manh dat
            Console.WriteLine("Area of the land");
            Console.Write("Enter Height: ");
            int Height = int.Parse(Console.ReadLine());
            Console.Write("Enter Width: ");
            int Width = int.Parse(Console.ReadLine());
            int Area = Height * Width;
            Console.WriteLine("Area :" + Area);

            //Tong hai gia tri
            SumOfTwoValue(10, 9);

            //Chuyen doi tien te
            Console.Write("Exchange currency USD to VND");
            Console.Write("Enter USD: ");
            float USD = int.Parse(Console.ReadLine());
            float ExchangeRate = 23000;
            float VND = USD * ExchangeRate;
            Console.WriteLine("VND = " + VND);

        }
        static void SumOfTwoValue(int A, int B)
        {
            int C = A + B;
            Console.WriteLine("Tong cua hai so: " + C);

            Thread.Sleep(0);
        }

        static void VariableDeclaration()
        {
            int i = 10;
            float f = 20.5f;
            double d = 20.5;
            Boolean b = true;
            char c = 'a';
            String s = "CodeGym";

            Console.WriteLine("Giá trị của biến i là " + i);
            Console.WriteLine("Giá trị của biến f là " + f);
            Console.WriteLine("Giá trị của biến d là " + d);
            Console.WriteLine("Giá trị của biến b là " + b);
            Console.WriteLine("Giá trị của biến c là " + c);
            Console.WriteLine("Giá trị của biến i là " + s);
        }

    }
}
