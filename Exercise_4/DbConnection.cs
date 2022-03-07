using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
   public abstract class DbConnection
    {
        public string connectionString;
        public TimeSpan Timeout;
        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException("Please enter a connection string");
            }
            this.connectionString = connectionString;
        }
        abstract public void Open();
       abstract public void Close();
   
    }

    class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString): base(connectionString)
        {
            Console.WriteLine("Created a Sql connection");
        }
        public override void Open()
        {
            Console.WriteLine("DB Connection is opened");
        }
        public override void Close()
        {
            Console.WriteLine("DB Connection is closed");
        }
    }
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
            Console.WriteLine("Created an Oracle connection");
        }
        public override void Open()
        {
            Console.WriteLine("DB Connection is opened");
        }
        public override void Close()
        {
            Console.WriteLine("DB Connection is closed");
        }
    }

}
