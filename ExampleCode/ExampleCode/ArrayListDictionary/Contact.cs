using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCode.ArrayListDictionary
{
    internal class Contact
    {
        public string Name { get; set; };
        public string PhoneNumber { get; set; }

        public Contact()
        {

        }

        public Contact(string name, string Phonenum)
        {
            Name = name;
            PhoneNumber = Phonenum;
        }

        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetPhoneNum(String Phonenum)
        {
            PhoneNumber = Phonenum;
        }
        public string GetPhoneNum()
        {
            return PhoneNumber;
        }
    }
}
