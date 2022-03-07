using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    [TestFixture]
    class TestExercise_2
    {
       [Test]

        public void IncreasesVoteValuebyOne()
        {
            StackOverFlowPost obj = new StackOverFlowPost("hi","hello");
            obj.UpVote();
            Assert.AreEqual(1, obj.vote);

        }
        [Test]
        public void DecreasesVoteValueByOne()
        {
            StackOverFlowPost obj = new StackOverFlowPost("hi", "hello");
            
            obj.DownVote();
            Assert.AreEqual(-1,obj.vote);

        }
        [Test]
        public void ReturnsVoteValue()
        {
            StackOverFlowPost obj = new StackOverFlowPost("hi", "hello");
            Assert.AreEqual(0,obj.getVoteValue());

        }

    }
}
