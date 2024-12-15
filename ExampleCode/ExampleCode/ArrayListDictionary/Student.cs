using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCode.ArrayListDictionary
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public  DateTime Birthday { get; set; }

        public Student() 
        {
        
        }

        public Student(string name, int age, DateTime birthday)
        {
            Name = name;
            Age = age;
            Birthday = birthday;
        }

        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }   
        public void SetAge(int age) 
        {
            Age = age; 
        }
        public int GetAge()
        {
            return Age;
        }
        public void SetBirthday(DateTime birthday)
        {
            Birthday= birthday;
        }
        public DateTime GetBirthday()
        {
            return Birthday;   
        }
        public override string ToString()
        {
            return "Ten: " + Name + ", Tuoi: " + Age +", Y-m-d: " + Birthday;
        }
    }
}
