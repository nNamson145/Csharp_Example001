using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCode.IntefaceTask
{
    internal class ISquare : IRectangle, InterfaceResizeable
    {
        double ResizeSquare;

        public ISquare()
        {
        }

        public ISquare(double side) : base(side, side)
        {
        }

        public ISquare(double side, string color, bool filled) : base(side, side, color, filled)
        {
        }

        public double getSide()
        {
            return getWidth();
        }

        public void setSide(double side)
        {
            base.setWidth(side);
            base.setLength(side);
        }
        public override void setWidth(double width)
        {
            setSide(width);
        }

        public override void setLength(double length)
        {
            setSide(length);
        }

        public override double getArea() 
        {
            return getSide() * 2;
        }

        public override string ToString()
        {
            return "A Square with side="
                    + getSide()
                    + ", which is a subclass of "
                    + base.ToString()
                    + " Resize : "
                    + GetResize();
        }

        public void Resize(double percent)
        {
            this.ResizeSquare = getSide() * percent;
        }
    }
}
