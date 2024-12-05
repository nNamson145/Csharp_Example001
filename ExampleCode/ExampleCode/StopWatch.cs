using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCode
{
    internal class StopWatch
    {
        private DateTime startTime;
        private DateTime endTime;



        public DateTime StartTime()
        {
            return startTime;
        }

        public DateTime EndTime() 
        {
            return endTime; 
        }




        public void Start()
        {
            startTime = DateTime.Now;
        }

        public void Stop() 
        {
            endTime = DateTime.Now;
        }

        public double GetElapsedTime()
        {
            return (endTime - startTime).TotalSeconds;/*.TotalMilliseconds;//chuyển đổi Timespan thành số milisecond*/
        }



    }
}
