namespace Extensibility
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\git\\GitHub\\Udemy\\C#\\C-Sharp-Intermediate-Course\\Section 6\\Extensibility\\log.txt"));

            dbMigrator.Migrate();
        }
    }
}