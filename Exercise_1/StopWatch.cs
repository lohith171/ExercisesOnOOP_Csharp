using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
   public class StopWatch
    {
        public bool isstart;
       public  DateTime startTime;
        public DateTime stopTime;
        public void Start()
        {
            if (!isstart)
            {
                startTime = DateTime.Now;
                isstart = true;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
        public double Stop()
        {
            if (!isstart) throw new InvalidOperationException();
            stopTime = DateTime.Now;
            TimeSpan duration = stopTime - startTime;
            isstart = false;
            return duration.Seconds;
        }
       
    }
}
