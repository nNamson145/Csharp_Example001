using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCode.ArrayListDictionary
{
    internal class FindMinMax
    {
        public int SizeList;

        public void FindMinMaxValue()
        {
            Console.Write("Nhap so luong phan tu trong danh sach: ");
            SizeList = int.Parse(Console.ReadLine());
            List<int> ListNum = new List<int>();
            for (int i = 0; i < SizeList; i++)
            {
                Console.WriteLine("Nhap phan tu " + i);
                int num = int.Parse(Console.ReadLine());
                ListNum.Add(num);
            }
            ListNum.Sort(); //Sắp xếp theo thứ tự tăng dần
            Console.WriteLine("Gia tri lon nhat trong danh sach la: " + ListNum.Last());
            ListNum.Sort((x,y) => y.CompareTo(x)); //Sắp xếp theo thứ tự giam dần
            Console.WriteLine("Gia tri nho nhat trong danh sach la: " + ListNum.Last());

        }

    }
}
