using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCode.IntefaceTask
{
    internal class ICircle : IShape , InterfaceResizeable
    {
        private double radius = 1.0;

        public ICircle()
        {
        }

        public ICircle(double radius)
        {
            this.radius = radius;
        }

        public ICircle(double radius, String color, bool filled) : base(color, filled)
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return radius;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public override double getArea()
        {
            return radius * radius * Math.PI;
        }

        public double getPerimeter()
        {
            return 2 * radius * Math.PI;
        }

        public override string ToString()
        {
            return "A Circle with radius="
                    + getRadius()
                    + ", which is a subclass of "
                    + base.ToString()
                    + " Resize: "
                    + GetResize();

        }
        public void Resize(double percent)
        {
            radius *= percent;
        }
        public double GetResize()
        {
            return radius;
        }
    }
}
