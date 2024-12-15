using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCode.ArrayListDictionary
{
    internal class SortTheList
    {
        public int SizeList;

        public void SortList()
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
            Console.WriteLine("===================");

            ListNum.Sort(); //Sắp xếp theo thứ tự tăng dần
            foreach (int num in ListNum)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("===================");

            ListNum.Sort((x, y) => y.CompareTo(x)); //Sắp xếp theo thứ tự giam dần
            foreach (int num in ListNum)
            {
                Console.WriteLine(num);
            }
        }
    }
}
