using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCode.IntefaceTask
{
    internal class IRectangle : IShape, InterfaceResizeable
    {
        private double width = 1.0;
        private double length = 1.0;

        public IRectangle()
        {
        }

        public IRectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        public IRectangle(double width, double length, string color, bool filled) : base(color, filled)
        {
            this.width = width;
            this.length = length;
        }

        public double getWidth()
        {
            return width;
        }

        public virtual void setWidth(double width)
        {
            this.width = width;
        }

        public double getLength()
        {
            return length;
        }

        public virtual void setLength(double length)
        {
            this.length = length;
        }

        public override double getArea()
        {
            return width * this.length;
        }

        public double getPerimeter()
        {
            return 2 * (width + this.length);
        }

        public override string ToString()
        {
            return "A Rectangle with width="
                    + getWidth()
                    + " and length="
                    + getLength()
                    + ", which is a subclass of "
                    + base.ToString()
                    + " Resize: "
                    + GetResize();
        }

        public void Resize(double percent)
        {
            this.width *= (1 + percent/100);
            this.length *= (1 + percent/100);
        }
        public double GetResize()
        {
            return this.width;
            return this.length;
        }
    }
}
