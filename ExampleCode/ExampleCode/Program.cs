﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            //3

            /*//In thời gian thực và hello world
            DateTime Now = DateTime.Now;
            Console.WriteLine("Hello World!" + " " + Now);*/

            /*//Khai bao bien
            VariableDeclaration();*/

            /*//Dien tich manh dat
            Console.WriteLine("Area of the land");
            Console.Write("Enter Height: ");
            int Height = int.Parse(Console.ReadLine());
            Console.Write("Enter Width: ");
            int Width = int.Parse(Console.ReadLine());
            int Area = Height * Width;
            Console.WriteLine("Area :" + Area);*/

            /*//Chuyen doi tien te
          Console.Write("Exchange currency USD to VND");
          Console.Write("Enter USD: ");
          float USD = int.Parse(Console.ReadLine());
          float ExchangeRate = 23000;
          float VND = USD * ExchangeRate;
          Console.WriteLine("VND = " + VND);*/

            /*//Tong hai gia tri
            SumOfTwoValue(10, 9);*/

            /*//Doi tuoi sang ngay
            Console.WriteLine("Nhap so tuoi cua ban : ");
            string AnyStr = Console.ReadLine();
            ConvStrToInt(AnyStr); */

            //4

            /*//Dùng thử case
            DemoSwitchCase();*/

            /*//đọc số thành chữ từ 0 đến 999
            ReadNum();*/

            /*//Giải phương tình bậc nhất
            LinearEquationResolver();*/

            /*//tính chỉ số cân nặng cơ thể
            Bodymassindex();*/

            /*//Kiểm tra năm nhuận
            CheckLeapYear();*/

            /*//Kiểm tra tháng có bao nhiêu ngày
            CheckDayOfMonth();*/


            //5

            /*//làm lại bài tập đếm ngày bằng tuổi có vòng lặp
            convertAgeWithLoop();*/

            /*//hiển thị tất cả các số chia hết cho 5 trong khoảng từ 0 đến 100
            Testloop();*/

            /*// Ứng dụng tính tiền lãi cho vay
            Interset();*/

            /*//Hiển thị các loại hình
            GeometryMenu();*/

            /*//Hiển thị các số nguyên tố từ 2 đến 100
            DisplaysInt();*/
        }

        ////////////////////////////////////////////////////////////
        /// <summary>
        /// Bai 3 : C# căn bản - Biến, kiểu dữ liệu và toán tử
        /// </summary>

        //Tổng hai số
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

        ////////////////////////////////////////////////////////////
        /// <summary>
        /// Bai 4 : Câu lệnh điều kiện (if - else // switch case)
        /// </summary>

        //Đổi String sang int
        public int ConvStrToInt(String AnyStr)
        {
            bool parseToInt = int.TryParse(AnyStr, out int numInt);
            if (parseToInt)
            {
                convertage(numInt);
            }
            else
            {
                Console.WriteLine("Nhap sang dinh dang co the chuyen sang int");
            }
            return numInt;
        }

        //Đổi tuổi sang ngày
        static void convertage(int age)
        {
            if (age <= 0 || age > 120)
            {
                Console.WriteLine("So tuoi khong hop le");
            }
            else
            {
                int Days = 365 * age;
                Console.WriteLine("So ngay ban da tho : " + Days);
            }
        }

        //Demo SwitchCase
        static void DemoSwitchCase()
        {
            Console.WriteLine("Nhap lua chon cua ban : ");
            string option = Console.ReadLine();
            bool IsConvertInt = int.TryParse(option, out int Num);
            if (IsConvertInt)
            {
                switch (Num)
                {
                    case 1:
                        Console.WriteLine("Ban chon 1");
                        break;
                    case 2:
                        Console.WriteLine("Ban chon 2");
                        break;
                    case 3:
                        Console.WriteLine("Ban chon 3");
                        break;
                    case 4:
                        Console.WriteLine("Ban chon 4");
                        break;
                    default:
                        Console.WriteLine("Khong co su lua chon nay");
                        break;
                }
            }

        }

        //Giải phương tình bậc nhất
        static void LinearEquationResolver()
        {
            Console.WriteLine("a * X + b = 0");
            Console.Write("Hay nhap a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hay nhap b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a != 0)
            {
                double solution = -b / a;
                Console.WriteLine("Solution is : ", solution);
            }
            else //a bằng 0
            {
                if (b == 0)
                {
                    Console.WriteLine("All X");
                }
                else //b khác 0
                {
                    Console.WriteLine("Nod Solution");
                }
            }
        }

        //chuyển số sang dnag chữ 0 đến 999
        static void ReadNum()
        {
            Console.WriteLine("Nhap so can doc : ");
            string InputStr = Console.ReadLine();
            bool IsInt = int.TryParse(InputStr, out int Num);
            //kiểm tra hàng đơn vị
            if (IsInt && Num > -1 && Num <= 10)
            {
                switch (Num)
                {
                    case 0: Console.WriteLine("zero"); break;
                    case 1: Console.WriteLine("One"); break;
                    case 2: Console.WriteLine("Two"); break;
                    case 3: Console.WriteLine("Three"); break;
                    case 4: Console.WriteLine("Four"); break;
                    case 5: Console.WriteLine("Five"); break;
                    case 6: Console.WriteLine("Six"); break;
                    case 7: Console.WriteLine("Seven"); break;
                    case 8: Console.WriteLine("Eight"); break;
                    case 9: Console.WriteLine("Nine"); break;
                    case 10: Console.WriteLine("Ten"); break;
                    default: break;
                }
            }
            //kiểm tra hàng chục nhỏ hơn 20
            if (IsInt && Num > 10 && Num <= 20)
            {
                switch (Num)
                {
                    case 10: Console.WriteLine("Ten"); break;
                    case 11: Console.WriteLine("Eleven"); break;
                    case 12: Console.WriteLine("Twelve"); break;
                    case 13: Console.WriteLine("Thirteen"); break;
                    case 14: Console.WriteLine("Fourteen"); break;
                    case 15: Console.WriteLine("Fifteen"); break;
                    case 16: Console.WriteLine("Sixteen"); break;
                    case 17: Console.WriteLine("Seventeen"); break;
                    case 18: Console.WriteLine("Eighteen"); break;
                    case 19: Console.WriteLine("Nineteen"); break;
                    default: break;
                }
            }
            //Kiểm tra số hàng chục lớn hơn 20
            if (IsInt && Num >= 20 && Num <= 99)
            {
                int ten = Num / 10;
                int one = Num % 10;
                switch (ten)
                {
                    case 2:
                        Console.Write("Twenty");
                        break;
                    case 3:
                        Console.Write("Thirty");
                        break;
                    case 4:
                        Console.Write("fourty");
                        break;
                    case 5:
                        Console.Write("fifty");
                        break;
                    case 6:
                        Console.Write("Sixty");
                        break;
                    case 7:
                        Console.Write("Seventy");
                        break;
                    case 8:
                        Console.Write("Eightty");
                        break;
                    case 9:
                        Console.Write("Ninety");
                        break;
                    default:
                        break;
                }
                if (one > 0)
                {
                    Console.Write(" ");
                    switch (one)
                    {
                        case 1:
                            Console.Write("One");
                            break;
                        case 2:
                            Console.Write("Two");
                            break;
                        case 3:
                            Console.Write("Three");
                            break;
                        case 4:
                            Console.Write("four");
                            break;
                        case 5:
                            Console.Write("five");
                            break;
                        case 6:
                            Console.Write("Six");
                            break;
                        case 7:
                            Console.Write("Seven");
                            break;
                        case 8:
                            Console.Write("Eight");
                            break;
                        case 9:
                            Console.Write("Nine");
                            break;
                        default:
                            break;
                    }
                }

            }
            //Kiểm tra số trăm lớn hơn hoặc bằng 100 và bé hơn 999
            if (IsInt && Num >= 100 && Num <= 999)
            {
                int hundred = Num / 100;
                int ten = (Num % 100) / 10;
                int one = (Num % 100) % 10;

                //Kiểm tra hàng trăm
                switch (hundred)
                {
                    case 1:
                        Console.Write("One hundred");
                        break;
                    case 2:
                        Console.Write("Two hundred");
                        break;
                    case 3:
                        Console.Write("Three hundred");
                        break;
                    case 4:
                        Console.Write("four hundred");
                        break;
                    case 5:
                        Console.Write("five hundred");
                        break;
                    case 6:
                        Console.Write("Six hundred");
                        break;
                    case 7:
                        Console.Write("Seven hundred");
                        break;
                    case 8:
                        Console.Write("Eight hundred");
                        break;
                    case 9:
                        Console.Write("Nine hundred");
                        break;
                    default:
                        break;
                }
                //Kiểm tra hàng chục
                if (ten != 0)
                {
                    switch (ten)
                    {
                        case 2:
                            Console.Write("Twenty");
                            break;
                        case 3:
                            Console.Write("Thirty");
                            break;
                        case 4:
                            Console.Write("fourty");
                            break;
                        case 5:
                            Console.Write("fifty");
                            break;
                        case 6:
                            Console.Write("Sixty");
                            break;
                        case 7:
                            Console.Write("Seventy");
                            break;
                        case 8:
                            Console.Write("Eightty");
                            break;
                        case 9:
                            Console.Write("Ninety");
                            break;
                        default:
                            break;
                    }
                    //Nếu hàng trăm kèm hàng chục và hàng đơn vị
                    if (one > 0 && ten != 0)
                    {
                        switch (one)
                        {
                            case 1:
                                Console.Write("One");
                                break;
                            case 2:
                                Console.Write("Two");
                                break;
                            case 3:
                                Console.Write("Three");
                                break;
                            case 4:
                                Console.Write("four");
                                break;
                            case 5:
                                Console.Write("five");
                                break;
                            case 6:
                                Console.Write("Six");
                                break;
                            case 7:
                                Console.Write("Seven");
                                break;
                            case 8:
                                Console.Write("Eight");
                                break;
                            case 9:
                                Console.Write("Nine");
                                break;
                            default:
                                break;
                        }
                    }
                }
                else //Không kèm hàng chục thì sẽ xuống else
                {
                    //Nếu số hàng trăm kèm hàng đơn vị
                    if (one > 0)
                    {
                        Console.Write(" ");
                        switch (one)
                        {
                            case 1:
                                Console.Write("And One");
                                break;
                            case 2:
                                Console.Write("And Two");
                                break;
                            case 3:
                                Console.Write("And Three");
                                break;
                            case 4:
                                Console.Write("And four");
                                break;
                            case 5:
                                Console.Write("And five");
                                break;
                            case 6:
                                Console.Write("And Six");
                                break;
                            case 7:
                                Console.Write("And Seven");
                                break;
                            case 8:
                                Console.Write("And Eight");
                                break;
                            case 9:
                                Console.Write("And Nine");
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            Console.ReadLine();
        }

        //tính chỉ số cân nặng cơ thể
        static void Bodymassindex()
        {
            Console.Write("Nhap chieu cao cua ban: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Nhap can nang cua ban: ");
            double weight = double.Parse(Console.ReadLine());

            double bmi = weight / Math.Pow(height,2); //Cân nặng chia cho chiều cao mũ 2(bình phương)
            bmi = Math.Round(bmi,1); //làm tròn

            if (bmi < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if (18.5 <= bmi && bmi <= 25.0)
            {
                Console.WriteLine("Normal");
            }
            else if (25.0 <= bmi && bmi <= 30.0)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Obese");
            }
            Console.WriteLine("Your bmi: " + bmi);
        }

        //Kiểm tra năm nhuận
        static void CheckLeapYear()
        {
            int Year;
            bool IsleapYear = false;

            Console.Write("Nhap so nam can kiem tra :");
            Year = Convert.ToInt32(Console.ReadLine());

            bool OutOf4 = Year % 4 == 0;
            if (OutOf4) 
            { 
                bool OutOf100 = Year % 100 == 0;
                if (OutOf100)
                {
                    bool OutOf400 = Year % 400 == 0;
                    if (OutOf400) 
                    {
                        IsleapYear = true;
                    }
                }
                else
                {
                    IsleapYear = true;
                }
            }
            if (IsleapYear)
            {
                Console.WriteLine("{0} is a leap year !!", Year);
            }
            else
            {
                Console.WriteLine("{0} isn't a leapp year!!", Year);
            }
        }

        //Kiểm tra tháng có bao nhiêu ngày
        static void CheckDayOfMonth()
        {
            Console.Write("Nhap thang can kiem tra cos bao nhieu ngay: ");
            int month = Convert.ToInt32(Console.ReadLine()); //xử lý nhiều loại dữ liệu hơn.

            switch (month)
            {
                case 2:
                    Console.WriteLine(" Thang 2 có 28 hoac 29 ngay");
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Thang {0} co 31 ngay", month);
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Thang {0} co 30 ngay", month);
                    break;
                default: 
                    Console.WriteLine(" Thang khong hop le");
                    break;
            }


        }

        /////////////////////////////////////////////////
        /// <summary>
        /// Bai 5 : Câu lệnh lặp (1), Câu lệnh lặp (2)
        /// </summary>

        //làm lại bài tập đếm ngày bằng tuổi có vòng lặp
        static void convertAgeWithLoop()
        {
            while (true)
            {
                Console.Write("Nhap so tuoi cua ban : ");
                string StrAge = Console.ReadLine();
                bool IsInt = int.TryParse(StrAge, out int age);

                if (IsInt)
                {
                    if (age <= 0 || age > 120)
                    {
                        Console.WriteLine("So tuoi khong hop le");
                    }
                    else
                    {
                        int Days = 365 * age;
                        Console.WriteLine("So ngay ban da tho : " + Days);
                        break;
                    }
                }
                else
                {
                    Console.Write("Ban nhap khong dung dinh dang so, xin hay nhap lai ! ");
                }
            }
        }

        //hiển thị tất cả các số chia hết cho 5 trong khoảng từ 0 đến 100
        static void Testloop()
        {
            Console.WriteLine("Hien thi cac so chia het cho 5 trong khoan 0 - 100");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 5 == 0)
                    Console.WriteLine("Cac so chia het cho 5 : " + i);
            }
        }

        // Ứng dụng tính tiền lãi cho vay
        static void Interset()
        {
            double money;
            int month;
            double IntersetRate;

            Console.Write("Nhap so tien gui: ");
            money = double.Parse(Console.ReadLine());

            Console.Write("Nhap so thang gui: ");
            month = int.Parse(Console.ReadLine());

            Console.Write("Nhap lai suat ngan hang: ");
            IntersetRate = double.Parse(Console.ReadLine());

            double TotalInterset = 0; // nếu ko gán giá trị nào thì sau vòng lặp (nếu vòng lặp ko chạy thì sẽ ko đưa ra biến đó là loại giá trị nào nên gây lỗi)
            for (int i = 0; i <= month; i++)
            {
                TotalInterset = money * (IntersetRate/100/12) * month;
            }

            Console.WriteLine("Tong tien lai: " + TotalInterset /*chỗ bị lỗi nếu không gán*/);
            

        }

        //Hiển thị các loại hình
        static void GeometryMenu()
        {
            Console.WriteLine("1. Print the rectangle"); 
            Console.WriteLine("2. Print the square triangle (The corner is square at 4 different angles: top-left, top-right, botton-left, botton-right)\r\n");
            Console.WriteLine("3. Print isosceles triangle");
            Console.WriteLine("4. Exit");

            Console.Write("Select: ");
            int Option = int.Parse(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    for (int i = 0;i < 3; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine("*");
                    }
                    break;
                case 2:
                    for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine("*");
                    }
                    break;
                case 3:
                    for (int i = 4; i >= 0; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine("*");
                    }
                    break;
                case 4: 
                    Console.ReadLine();
                    break;
                    
            }
        }

        //Hiển thị các số nguyên tố từ 2 đến 100
        static void DisplaysInt()
        {
            int CheckNum = 0;
            Console.WriteLine("Danh sach so nguyen to tu 2 den 100:");
            for (int i = 2; i <=100 ; i++)
            {
                for(int j = 1;j <= i ; j++)
                {
                    if (i % j == 0)
                    {
                        CheckNum++;
                    }
                }
                if(CheckNum == 2)
                {
                    Console.WriteLine(i);
                }
                CheckNum = 0;
            }
        }





    }
}
