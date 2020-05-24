using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Exercise1_S5
{
    class Program
    {
        static void Main(string[] args)
        {
            string instruction = "create DB";
            var dbConnection = new SqlConnection(instruction);
            var command = new DbCommand(dbConnection, instruction);
            command.Execute();
        }
    }
}
