using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    [TestFixture]
    class TestExercise_3
    {
        [TestCase(10,5)]
        [TestCase(0,"hi")]
        [TestCase(100,3.3)]

        public void PushesObjectIntoStack(int n,Object ob)
        {
            StackClass obj = new StackClass();
            obj.Push(ob);
            Assert.AreEqual(1, obj.arr.Count);

        }
        [TestCase(10,"hi")]
        [TestCase(0, "hi")]
        [TestCase(100, "hello")]
        [TestCase(-10, "hi")]

        public void PopsTopElementFromStack_ReturnsItsValue(int n,Object ob)
        {
            StackClass obj = new StackClass();
            for(int i = 0; i < n; i++)
            {
                obj.arr.Add(ob);
            }

            if (obj.arr.Count== 0) Assert.Throws<InvalidOperationException>(() => obj.Pop());
            else
            {
                Object val = obj.Pop();
                Assert.AreEqual(ob, val);
                Assert.AreEqual(n - 1, obj.arr.Count);
            }
        }

        [TestCase(10,5)]
        [TestCase(0,0)]
        [TestCase(-1,"hi")]
        public void ClearsTheStack(int n,Object ob)
        {
            StackClass obj = new StackClass();
            for(int i = 0; i < n; i++)
            {
                obj.arr.Add(ob);
            }
            obj.Clear();
            Assert.AreEqual(0, obj.arr.Count);
        }
    }
}
