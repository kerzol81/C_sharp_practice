using System;

namespace Polimorphism_Excercise
{
    abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan TimeOut { get; private set; }
        protected DbConnection(string connectionString, TimeSpan timeOut)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException("connection_string cannot be emtpty");
            }
            ConnectionString = connectionString;
            TimeOut = timeOut;
        }

        protected DbConnection()
        {
        }

        public abstract void Open();
        public abstract void Close();
    }
}
