using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCode.ArrayListDictionary
{
    internal class DeleteElementOfList
    {
        
        public void DeleteElementOnList()
        {
            List<int> ListNum = new List<int>();
           
            Console.WriteLine("Nhap phan tu: ");
            int num = int.Parse(Console.ReadLine());
            ListNum.Add(num);

            Console.WriteLine("Ban co muon xoa so vừa nhap khong ? Nhap y hoac n");
            string reply = Console.ReadLine();

            Console.WriteLine("===================");


            if (reply == "y")
            {
                ListNum.Remove(num); //xóa bằng giá trị, không xóa bằng index
                Console.WriteLine("danh sach: ");
                foreach (int i in ListNum)
                {
                    Console.WriteLine(i);
                }

            }
            else if (reply == "n")
            {
                Console.WriteLine("danh sach: ");
                foreach (int i in ListNum)
                {
                    Console.WriteLine(i);
                }
            } 
        }
    }
}
