using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCode.ArrayListDictionary
{
    internal class AddAndDisplayElements
    {
        public int SizeList;

        public void AddElements()
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

            Console.WriteLine("danh sach: ");
            foreach (int num in ListNum)
            { 
                Console.WriteLine(num);
            }
        }

    }
}
