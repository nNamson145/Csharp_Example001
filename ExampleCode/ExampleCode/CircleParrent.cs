using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCode
{
    internal class CircleParrent
    {
        protected double radius = 10.0;
        protected string color = "Red";

        public CircleParrent()
        {

        }
        public CircleParrent(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public double GetRadius()
        { 
            return radius;
        }
        

        public string GetColor() 
        {
            return color;
        }

        public virtual void CalculateArea()
        {
            double area = Math.PI * Math.Pow(this.radius, 2);
            Console.WriteLine("Dien tich hinh tron: " + area.ToString());
        }


    }
}
