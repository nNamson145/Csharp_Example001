using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCode
{
    internal class Point2D
    {
        public float x = 0.0f;
        public float y = 0.0f;

        public Point2D() 
        {
            
        }
        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float GetX() 
        {
            return x;
        }
        public void SetX(float x)
        {
            this.x = x;
        }

        public float GetY()
        {
            return y;
        }

        public void SetY(float y)
        {
            this.y = y;
        }

        public void SetXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float[] GetXY()
        {
            return new float[] { this.x, this.y };
        }

        public override string ToString()
        {

            return $"point2D posision: {x}, {y}";
           
        }
    }
}
