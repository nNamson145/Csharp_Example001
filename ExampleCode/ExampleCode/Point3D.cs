using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCode
{
    internal class Point3D : Point2D
    {
        float z = 0.0f;

        public Point3D()
        {

        }
        public Point3D(float z)
        {
            this.z = z;
        }
        public float GetZ()
        {
            return z;
        }
        public void SetZ(float z)
        {
            this.z = z;
        }
        public void SetZXY(float x, float y, float z)
        {
            this.z = z;
            this.x = x;
            this.y = y;
        }
        public float[] GetXYZ() 
        {
            return new float[] { this.x,this.y , this.z };
        }
        public override string ToString()
        {
            return $"(point3D posision:{x}, {y}, {z})";
        }
    }
}
