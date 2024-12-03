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
        public int Speed = 1;
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

        public void SetProperty(int Sp, string Cl, int Rad)
        {
            switch (Sp)
            {
                case 1:
                    this.Speed = 1;
                    break;
                case 2:
                    this.Speed = 2;
                    break;
                case 3:
                    this.Speed = 3;
                    break;
            }

            this.Color = Cl;

            this.radius = Rad;
        }

        public int GetRadius()
        {
            return this.radius;
        }
        public bool GetFanStat()
        {
            return this.FanStat;
        }
        public string GetColor()
        {
            return this.Color;
        }
    }
}
