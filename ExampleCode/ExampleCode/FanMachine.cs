using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCode
{
    internal class FanMachine
    {
        public const int SLOW = 1, MEDIUM = 2, FAST = 3;
        
        private bool fanStat = false;
        private int speed = SLOW;
        private double radius = 5;
        private string Color = "blue";

        public FanMachine()
        {

        }

        public void TurnOn(bool FanOn)
        {
            FanOn = true;
            fanStat = FanOn;
        }

        public void SetFanProperty(int? Sp = null, string Cl = null, double? Rad = null, bool? On = null)
        {
            if (Sp.HasValue)
            {
                switch (Sp)
                {
                    case SLOW:
                        this.speed = SLOW;
                        break;
                    case MEDIUM:
                        this.speed = MEDIUM;
                        break;
                    case FAST:
                        this.speed = FAST;
                        break;
                }
            }

            if (Cl != null)
            {
                this.Color = Cl;
            }

            if (Rad.HasValue)
            {
                this.radius = Rad.Value;
            }
        }

        public double GetRadius()
        {
            return this.radius;
        }
        public bool GetFanStat()
        {
            return this.fanStat;
        }
        public string GetColor()
        {
            return this.Color;
        }
        public int GetSpeed()
        {
            return this.speed;
        }
    }
}
