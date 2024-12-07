using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCode
{
    internal class Shape
    {
        protected string color = "green";
        protected bool filled = true;

        public Shape()
        {

        }

        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }
        //get set color
        public string GetColor()
        {
            return color;
        }
        public string SetColor(string colo)
        {
            this.color = colo;
            return this.color;
        }


        //get set filled
        public bool GetFilled()
        {
            return filled;
        }

        public bool SetFilled(bool fill)
        {
            this.filled = fill;
            return this.filled;
        }




        public virtual string ToString()
        {
            return "A Shape with color of " + GetColor() + " and " + (GetFilled() ? " filled " : " not filled ");   
        }
        
    }
}
