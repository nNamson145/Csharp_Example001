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

            SumOfTwoValue(10, 9);

            //DrawBorder();

            //Dien tich manh dat
            Console.WriteLine("Area of the land");
            Console.Write("Enter Height: ");
            int Height = int.Parse(Console.ReadLine());
            Console.Write("Enter Width: ");
            int Width = int.Parse(Console.ReadLine());
            int Area = Height * Width;
            Console.WriteLine("Area :" + Area);


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
        
    }
}
