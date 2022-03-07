using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOnInterfaces
{
    [TestFixture]
    class TestExercise_5
    {
        [Test]
        public void ChecksIfActivityIsRegistered()
        {
            WorkFlow obj = new WorkFlow();
            IActivity activity = new Activity();
            obj.RegisterActivity(activity);
            Assert.AreEqual(1, obj._Activties.Count);
            
        }
        [Test]

        public void ChecksGetActivities()
        {
            WorkFlow obj = new WorkFlow();
            Assert.IsInstanceOf(typeof(IList<IActivity>), obj.GetActivities());
        }

        [Test]
        public void ChecksExecuteMethod()
        {
            IActivity obj = new Activity();
            var stringWriter = new System.IO.StringWriter();
            Console.SetOut(stringWriter);
            obj.Execute();
            Assert.AreEqual("Activity is executed\r\n", stringWriter.ToString());
        }
    }
}
