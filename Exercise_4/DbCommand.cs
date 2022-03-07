using System;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class DbCommand
    {
        DbConnection dbConnection;
      
        public DbCommand(DbConnection dbConnection)
        {
            this.dbConnection = dbConnection ?? throw new InvalidOperationException("DBConnection required.");
            
        }

        public void Execute()
        {
            dbConnection.Open();
            Console.WriteLine("DB is running");
            dbConnection.Close();
        }
    }
}
