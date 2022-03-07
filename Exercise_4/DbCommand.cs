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
        string db;

        public DbCommand(DbConnection dbConnection,string db)
        {
            this.dbConnection = dbConnection ?? throw new InvalidOperationException("DBConnection required.");
            this.db = db ?? throw new InvalidOperationException("Db is required");
        }

        public void Execute(string db)
        {
            dbConnection.Open(db);
            Console.WriteLine(db+" is running");
            dbConnection.Close(db);
        }
    }
}
