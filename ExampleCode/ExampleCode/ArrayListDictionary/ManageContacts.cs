using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCode.ArrayListDictionary
{
    internal class ManageContacts
    {
        public static void OpenContacts()
        {
            do
            {
                Console.WriteLine("Menu danh ba dien thoai");
                int ConvertToInt = ConvertInt(Console.ReadLine());
            }
            while(true);
        } 

        public static int ConvertInt (string str)
        {
            bool ConvertToInt = int.TryParse(str, out int resultInt);
            if (ConvertToInt == false)
            {
                Console.WriteLine("Lua chon khong hop le");
                return 0;
            }
            return resultInt;
        }

        public static void AddContact()
        {

        }
    }
}
