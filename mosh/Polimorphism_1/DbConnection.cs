using System;

namespace Polimorphism_Excercise
{
    abstract class DbConnection : Connection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; private set; }

        public DbConnection(string connectionstring)
        {
            if (string.IsNullOrEmpty(connectionstring))
            {
                throw new InvalidOperationException("connectionstring cannot be empty");
            }
            this.ConnectionString = connectionstring;
        }
    }
}
