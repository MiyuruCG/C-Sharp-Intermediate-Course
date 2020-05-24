using System;

namespace Exercise1_S5
{
    public class SqlConnection : DbConnection
    {

        public SqlConnection(string connectionString) : base(connectionString)
        {

        }

        public override void Close()
        {
            Console.WriteLine("Close Connection in SQL DB");

        }

        public override void Open()
        {
            Console.WriteLine("Open Connection in SQL DB");

        }
    }
}
