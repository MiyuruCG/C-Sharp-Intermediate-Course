using System;

namespace Exercise1_S5
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }


        public DbConnection( string connectionString)
        {
            if (connectionString == null)
            {
                throw new ArgumentNullException();
            }
        }

        public abstract void Open();

        public abstract void Close();
    }
}
