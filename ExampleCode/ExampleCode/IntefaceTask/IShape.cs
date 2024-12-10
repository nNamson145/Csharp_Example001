using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCode.IntefaceTask
{
    public abstract class IShape //: InterfaceColorable
    {
        private string color = "green";
        private bool filled = true;

        public IShape()
        {
        }

        public IShape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public string getColor()
        {
            return color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public bool isFilled()
        {
            return filled;
        }

        public void setFilled(bool filled)
        {
            this.filled = filled;
        }

        public abstract double getArea();

        public override string ToString()
        {
            return "A Shape with color of "
                    + getColor()
                    + " and "
                    + (isFilled() ? "filled" : "not filled");
        }

        /*public void HowToColor()
        {
            
        }*/
    }
}
