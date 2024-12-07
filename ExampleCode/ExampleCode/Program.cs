using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
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

            //5.(1)

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

            //5.(2)

            /*//Thiết kế menu cho ứng dụng
            AppMenu();*/

            /*//Kiểm tra số nguyên tố
            CheckNumPrime();*/

            /*//Tìm ước số chung lớn nhất
            GreatestCommonFactor();*/

            /*//Hiển thị 20 số nguyên tố đầu tiên
            Display20Int();*/


            //6

            //Mảng 1 chiều

            /*//thử mảng
            TestArray();*/

            /*//Tính tổng các phần tử của mảng
            SumOfElement();*/

            /*//Tìm giá trị trong mảng
            FindPositionInList();*/

            /*//Tìm giá trị lớn nhất trong mảng
            LargestValue();*/

            /* //Thêm phần tử vào mảng
           AddElementArr();*/

            //Mảng đa chiều

            /*//Tìm phần tử lớn nhất trong mảng hai chiều
            FindMaxValueMultipleArray();*/



            //7

            /*//Viết phương thức xoá phần tử khỏi mảng
            DeleteElementOfArray();*/

            /*//Viết phương thức đếm số lần xuất hiện của ký tự trong chuỗi
            InputCountChar();*/

            //8

            /*//Xây dựng lớp Fan
            FanMachine Fan1 = new FanMachine();
            Fan1.TurnOn(true);
            Fan1.SetFanProperty( FanMachine.FAST, "Yellow", 10);
            
            FanMachine Fan2 = new FanMachine();
            
            Fan2.SetFanProperty( FanMachine.MEDIUM, "Blue", 5);


            if (Fan1.GetFanStat() == false)
            {
                Console.WriteLine("Speed: " + Fan1.GetSpeed() + " Color: " + Fan1.GetColor() + " Radius: " + Fan1.GetRadius() + " Fan is off");
            }
            else
            {
                Console.WriteLine("Speed: " + Fan1.GetSpeed() + " Color: " + Fan1.GetColor() + " Radius: " + Fan1.GetRadius() + " Fan is on");
            }

            if (Fan2.GetFanStat() == false)
            {
                Console.WriteLine("Speed: " + Fan2.GetSpeed() + " Color: " + Fan2.GetColor() + " Radius: " + Fan2.GetRadius() + " Fan is off");
            }
            else
            {
                Console.WriteLine("Speed: " + Fan2.GetSpeed() + " Color: " + Fan2.GetColor() + " Radius: " + Fan2.GetRadius() + " Fan is on");
            }*/

            /*//Xây dựng lớp StopWatch
            int n = 50000;
            int[] array = new int[n];
            Random randomValue = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = randomValue.Next(1,100000);
            }

            StopWatch Watch = new StopWatch();

            Watch.Start();

            SelectionSort(array);

            Watch.Stop();

            Console.WriteLine("Thoi gian bd: " + Watch.StartTime());
            Console.WriteLine("Thoi gian kt: " + Watch.EndTime());
            Console.WriteLine("Thoi gian thuc thi: " + Watch.GetElapsedTime() + " giay");*/
            
            //9

            //Lớp Circle và Cylinder
            CircleParrent Circle = new CircleParrent(10,"Black");
            Console.WriteLine("ban kinh: " +  Circle.GetRadius() + " mau: " + Circle.GetColor());
            Circle.CalculateArea();

            CylinderChildOfCircle cylinder = new CylinderChildOfCircle(20);
            cylinder.CalculateVolume();

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

        //Câu lệnh lặp (1)


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
                TotalInterset = money * (IntersetRate / 100 / 12) * month;
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
                    for (int i = 0; i < 3; i++)
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
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        CheckNum++;
                    }
                }
                if (CheckNum == 2)
                {
                    Console.WriteLine(i);
                }
                CheckNum = 0;
            }
        }


        //Câu lệnh lặp (2)


        //Thiết kế menu cho ứng dụng
        static void AppMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Draw the triangle");
            Console.WriteLine("2. Draw the square");
            Console.WriteLine("3. Draw the rectangle");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice: ");
            int choice = Int32.Parse(Console.ReadLine());

            while (choice != 0)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Draw the triangle");
                        Console.WriteLine("******");
                        Console.WriteLine("*****");
                        Console.WriteLine("****");
                        Console.WriteLine("***");
                        Console.WriteLine("**");
                        Console.WriteLine("*");
                        break;
                    case 2:
                        Console.WriteLine("Draw the square");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        break;
                    case 3:
                        Console.WriteLine("Draw the rectangle");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
                break;
            }
        }

        //Kiểm tra số nguyên tố
        static void CheckNumPrime()
        {
            int number;
            Console.Write("Nhap so: ");
            number = Int32.Parse(Console.ReadLine());


            if (number < 2)
            {
                Console.WriteLine(number + " khong phai so nguyen to");
            }
            else
            {
                int i = 2;
                bool check = true;
                while (i <= Math.Sqrt(number))
                {
                    if (number % i == 0)
                    {
                        check = false;
                        break;
                    }
                    i++;
                }
                if (check)
                {
                    Console.WriteLine(number + " la so nguyen to");
                }
                else
                {
                    Console.WriteLine(number + " khong phai so nguyen to");
                }
            }
        }

        //Tìm ước số chung lớn nhất
        static void GreatestCommonFactor()
        {
            Console.WriteLine("Nhap a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a == 0 || b == 0)
            {
                Console.WriteLine("Khong co uoc chung lon nhat");
            }
            else
            {
                while (a != b)
                {
                    if (a > b)
                    {
                        a = a - b;
                    }
                    else
                    {
                        b = b - a;
                    }
                }
                Console.WriteLine("Uoc chung lon nhat : " + a);
            }
        }

        //Debug ứng dụng C#

        //Hiển tị 20 số nguyên tố đầu tiên
        static void Display20Int()
        {
            Console.Write("So luong so nguyen to can in ra: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            for (int i = 2; i <= number; i++) 
            {
                for (int j = 1; j <= i; j++) 
                {
                    if(i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(i);
                }
                count = 0;
            }
        }

        /////////////////////////////////////////////////
        /// <summary>
        /// Bai 6 : Mảng 1 chiều
        /// </summary>

        //thử mảng
        static void TestArray()
        {
            
            double[] myList = new double[10] {1,2,3,4,5,6,7,8,9,10};
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }

            //tham chiếu
            double[] Refer = myList;
        }

        //tính tổng các phần tử của mảng
        static void SumOfElement()
        {
            int[] array = new int[5];
            array[0] = 11;
            array[1] = 22;
            array[2] = 33;
            array[3] = 44;
            array[4] = 55;

            foreach (int i in array)
            {
                Console.WriteLine( i + "+");
            }    

            int Sum = 0;
            for (int i = 0; i < array.Length; i++) 
            {
                Sum += array[i];
            }
            Console.WriteLine(" = " + Sum);
        }

        //Tìm giá trị trong mảng
        static void FindPositionInList()
        {
            string[] nameA = { "Son", "Nhi", "Duy", "Dat", "Huan", "Bao", "Khanh", "Cong", "Su" };

            Console.WriteLine("Nhap ten can tim kiem: ");
            String input_name = Console.ReadLine();

            bool isFound = false;
            for (int i = 0; i < nameA.Length; i++) 
            {
                if(nameA[i].Equals(input_name))
                {
                    Console.WriteLine("So thu tu của " + input_name + " la " + (i + 1));
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("khong tim thay ten");
            }    
        }

        //Tìm giá trị lớn nhất trong mảng
        static void LargestValue()
        {
            int size;
            int[] array;
            do
            {
                Console.WriteLine("Hay nhap kich thuoc mang : ");
                size = Int32.Parse(Console.ReadLine());
                if (size > 20)
                    Console.WriteLine("khong qua 20 ");
            }
            while (size > 20);
            array = new int[size];
            int i = 0;
            while(i < array.Length)
            {
                Console.WriteLine("Nhap gia tri " + (i + 1) + " : ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            for(int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j]);
            }

            int max = array[0];
            int index = 1;
            for(int j = 0 ; j < array.Length; j++)
            {
                if(array[j] > max)
                {
                    max = array[j];
                    index = j + 1;
                }
            }
            Console.WriteLine("Gia tri lon nhat trong array la : " + max + " tai vi tri " + index);
        }

        //Thêm phần tử vào mảng
        static void AddElementArr()
        {
            int[] ArrayNum = new int[10] {11,12,13,14,15,16,17,18,19,20};
            foreach (int i in ArrayNum)
            {
                int IndexAN = Array.IndexOf(ArrayNum, i);
                Console.WriteLine("ArrayNum[{0}] = {1}",IndexAN,i);
            }

            Console.WriteLine("Hay nhap gia tri ban muon thay doi: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap vi tri trong mang ban muon thay doi:");

            int xindex = int.Parse(Console.ReadLine());

            if (xindex < 0 && xindex >= ArrayNum.Length - 1)
            {
                Console.WriteLine("Vi tri nam ngoai mang !!");
            }
            else
            {
                ArrayNum[xindex] = x;
            }

            for (int i = 0; i < ArrayNum.Length; i++)
            {
                Console.WriteLine("ArrayNum[{0}] = {1}", i, ArrayNum[i]);
            }
        }

        //Mảng đa chiều
        ////////


        //thử mảng
        static void MultiArray()
        {

        }

        //Mảng hai chiều – tạo bản đồ trò chơi MineSweeper
        static void MinreSweeper()
        {
            string[,] map = { { "*" } };
            Console.WriteLine("*");

        }

        //Tìm phần tử lớn nhất trong mảng hai chiều
        static void FindMaxValueMultipleArray()
        {
            int[,] matrixArray = new int[4,4];
            Random rand = new Random();
            int maxValue = matrixArray[0,0];
            for(int row = 0;  row < matrixArray.GetLength(0); row++)
            {
                for (int column = 0; column < matrixArray.GetLength(1); column++)
                {
                    matrixArray[row, column] = rand.Next(1,100); 
                }
            }
            for (int row = 0; row < matrixArray.GetLength(0); row++)
            {
                Console.WriteLine("\n");
                for (int column = 0; column < matrixArray.GetLength(1); column++)
                {
                    Console.Write(matrixArray[row, column] + " ");
                }
            }
            Console.WriteLine("\n");
            for(int row = 0;row < matrixArray.GetLength(0); row++)
            {
                for(int column = 0;column < matrixArray.GetLength(1); column++)
                {
                    if(maxValue < matrixArray[row, column])
                    {
                        maxValue = matrixArray[row, column];
                    }
                }
            }
            Console.WriteLine("Gia tri lon nhat la: " + maxValue);
        }

        //Mảng hai chiều - tính tổng các số ở đường chéo chính của ma trận vuông
        static void TotalDiagonalSquareMatrix()
        {
            int[,] matrixSquare = new int[4, 4];
            Random rand = new Random();
            int maxValue = matrixSquare[0, 0];
            for (int row = 0; row < matrixSquare.GetLength(0); row++)
            {
                for (int column = 0; column < matrixSquare.GetLength(1); column++)
                {
                    matrixSquare[row, column] = rand.Next(1, 10);
                }
            }
            for (int row = 0; row < matrixSquare.GetLength(0); row++)
            {
                Console.WriteLine("\n");
                for (int column = 0; column < matrixSquare.GetLength(1); column++)
                {
                    Console.Write(matrixSquare[row, column] + " ");
                }
            }
            Console.WriteLine("\n");
            for (int row = 0; row < matrixSquare.GetLength(0); row++)
            {
                Console.WriteLine("\n");
                for (int column = 0; column < matrixSquare.GetLength(1); column++)
                {
                    Console.Write(matrixSquare[row, column] + " ");
                }
            }

        }

        /////////////////////////////////////////////////
        /// <summary>
        /// Bai 7 : Hàm và phương thức trong C#
        /// </summary>

        //Viết phương thức xoá phần tử khỏi mảng
        static void DeleteElementOfArray()
        {

            Console.Write("Nhap so luong phan tu cua mang: ");
            int size = int.Parse(Console.ReadLine());
            int[] Array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Nhap gia tri cua " + i + " : ");
                int input = int.Parse(Console.ReadLine());
                Array[i] = input;
            }

            int x = 0;
            bool IscorrectValue = true;
            do
            {
                Console.Write("Hay nhap phan tu can xoa trong mang: ");
                x = int.Parse(Console.ReadLine());
                for (int i = 0; i < Array.Length; i++)
                {
                    if (Array[i] == x)
                    {
                        Console.WriteLine(x + " Nam o vi tri " + i);
                        IscorrectValue = false;
                        break;
                    }
                }
            }
            while (IscorrectValue);

            int[] newArray = new int[Array.Length -1];
            int j = 0;

            for (int i = 0 ; i < Array.Length; i++)
            {
                if ( Array[i]  == x)
                {
                    continue;
                }
                newArray[j++] = Array[i];
            }

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine("Vi tri " + i + " : " + newArray[i]);
            }


        }

        // Phương thức đếm số lần xuất hiện của ký tự trong chuỗi
        static void InputCountChar()
        {
            Console.Write("Nhap chuoi ki tu: ");
            string allSentence = Console.ReadLine();

            Console.Write("ki tu can dem trong chuoi: ");
            char character = Console.ReadKey().KeyChar; //kí tự duy nhất().không phân biệt kí tự hoa hay thường
            Console.WriteLine();

            int Num = countchar(allSentence, character);

            Console.WriteLine("So lan ki tu xuat hien trong chuoi ki tu la: " + Num);


        }//chính
        static int countchar(string allSentence, char character)
        {
            int countNum = 0;
            for (int i = 0; i < allSentence.Length; i++)
            {
                if(allSentence[i] == character)
                {
                    countNum++;
                }
            }
            return countNum;
        }


        /// <summary>
        /// Bai 8 : Lớp và hướng đối tượng
        /// </summary>

        //Thuật toán selection sort
        static void SelectionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                //Hoán đổi giá trị c = a, a = b, b = c 
                int temporary = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temporary;
            }
        }
    }
}
