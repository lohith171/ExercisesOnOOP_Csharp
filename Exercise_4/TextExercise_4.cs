using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    [TestFixture]
    class TextExercise_4
    {
        [Test]

        public void OpensDataBaseConnection()
        {
            DbConnection obj = new SqlConnection("Sql ConnectionString");
            var stringWriter = new System.IO.StringWriter();
            Console.SetOut(stringWriter);
            obj.Open();
            Assert.AreEqual("DB Connection is opened\r\n", stringWriter.ToString());
        }
        [Test]
        public void ClosesDataBaseConnection()
        {
            DbConnection obj = new OracleConnection("Sql ConnectionString");
            var stringWriter = new System.IO.StringWriter();
            Console.SetOut(stringWriter);
            obj.Close();
            Assert.AreEqual("DB Connection is closed\r\n", stringWriter.ToString());
        }
        [Test]
      
        public void ExecutesDataBaseCommand()
        {
            Mock<DbConnection> mockObj = new Mock<DbConnection>("hello");
            DbCommand obj = new DbCommand(mockObj.Object);
            var stringWriter = new System.IO.StringWriter();
            Console.SetOut(stringWriter);
            obj.Execute();
            Assert.AreEqual("DB is running\r\n", stringWriter.ToString());
        }
    }
}
