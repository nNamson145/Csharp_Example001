using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCode
{
    internal class FanMachine
    {
        private bool FanStat = false;
        int Speed = 1;
        private int radius = 5;
        private string Color = "blue";

        public FanMachine()
        {

        }

        public void TurnOn(bool FanOn)
        {
            FanOn = true;
            FanStat = FanOn;
        }

        public void SetSpeed(int Sp)
        {
            Speed = Sp;
        }

        public void SetColor(string Cl)
        {
            Color = Cl;
        }

        public void SetRadius(int Rad)
        {
            radius = Rad;
        }

        public static void FanInfo(bool FanState, int Speed, int radius, string Color)
        {
            if(FanState = false)
            {
                Console.WriteLine("Speed: " + Speed + " Color: " + Color + " Radius: " + radius + " Fan is off");
            }
            Console.WriteLine("Speed: " + Speed + " Color: " + Color + " Radius: " + radius + " Fan is on");
        }
    }
}
