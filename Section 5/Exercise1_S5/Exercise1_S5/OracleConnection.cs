using System;

namespace Exercise1_S5
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Close()
        {
            Console.WriteLine("Close Connection in Oracle DB");
        }

        public override void Open()
        {
            Console.WriteLine("Open Connection in Oracle DB");

        }
    }
}
