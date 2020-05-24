using System;

namespace Exercise1_S5
{
    public class DbCommand
    {
        private DbConnection dbConnection;
        private string instruction;
        
        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null || instruction == null)
            {
                throw new NullReferenceException();
            }

            this.dbConnection = dbConnection;
            this.instruction = instruction;
        }

        public void Execute()
        {
            var sql = new SqlConnection(this.instruction);
            var oracle = new OracleConnection(this.instruction);

            if (dbConnection == new SqlConnection(this.instruction))
            {
                sql.Open();
                Console.WriteLine("Run "+instruction);
                sql.Close();
            }
            else if (dbConnection == oracle)
            {
                oracle.Open();
                Console.WriteLine("Run "+instruction);
                oracle.Close();
            }
            else
            {
                Console.WriteLine("Incorrect code");
            }
        }

    }
}
