using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    [TestFixture]
   public class TestExercise_1
    {
       [TestCase(true)]
       [TestCase(false)]

       public void StartsTheStopWatch(bool flag)
        {
            StopWatch obj = new StopWatch();
            obj.isstart = flag;
            if(flag)
            Assert.Throws<InvalidOperationException>(() => obj.Start());
            else
            {
                obj.Start();
                Assert.AreEqual(true,obj.isstart);
            }
        }
        [TestCase(true,"2022-03-01")]
        [TestCase(true, "2022-03-03")]
        [TestCase(false,"2022/03/02")]
        [TestCase(false, "2022-03-01")]
        public void StopsTheStopWatchAndReturnsDuration(bool flag,string _starttime)
        {
            StopWatch obj = new StopWatch();
            obj.isstart = flag;
            obj.startTime = DateTime.Parse(_starttime);
            if (!flag)
                Assert.Throws<InvalidOperationException>(() => obj.Stop());
            else
            {
                double duration= obj.Stop();
                Assert.AreEqual(false, obj.isstart);
                Assert.AreEqual(duration,(obj.stopTime - obj.startTime).Seconds);
            }
        }
        

    }
}
