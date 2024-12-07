using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCode
{
    internal class CylinderChildOfCircle : CircleParrent
    {
        protected double height;

        public CylinderChildOfCircle()
        {

        }

        public CylinderChildOfCircle(double height)
        {
            this.height = height;
        }
        public double GetHeight()
        {
            return height;
        }

        public virtual void CalculateVolume()
        {
            double volumeCylinder = Math.PI * radius * height;
            Console.WriteLine("The tich hinh tru: " + volumeCylinder.ToString());
        }



    }
}
