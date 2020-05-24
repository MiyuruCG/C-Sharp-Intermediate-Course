using System;

namespace Extensibility
{

    public class DbMigrator
    {
        private readonly ILogger logger;

        public DbMigrator(ILogger logger)
        {
            this.logger = logger;
        }

        public void Migrate()
        {
            logger.LogInfo("Migration Started at " + DateTime.Now);

            //code ...

            logger.LogInfo("Migration Finished at " + DateTime.Now);
        }
    }
}