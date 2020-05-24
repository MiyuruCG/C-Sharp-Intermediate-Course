namespace Exercise1_S5
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlConnection("Connect");
            sql.Open();
            sql.Close();
        }
    }
}
