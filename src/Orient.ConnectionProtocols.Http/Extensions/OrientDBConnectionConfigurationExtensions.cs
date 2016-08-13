using OrientDB.Core;
using OrientDB.Core.Configuration;
using System;

namespace OrientDB.ConnectionProtocols.Http.Extensions
{
    public static class OrientDBConnectionConfigurationExtensions
    {
        public static OrientDBConfiguration HttpProtocol(this OrientDBConnectionConfiguration configuration, string hostName, string userName, string password, string database, int port = 2480)
        {
            return configuration.HttpProtocol(new HttpConnectionOptions
            {
                Database = database,
                HostName = hostName,
                Password = password,
                Port = port,
                UserName = userName
            });
        }

        public static OrientDBConfiguration HttpProtocol(this OrientDBConnectionConfiguration configuration, HttpConnectionOptions connectionOptions)
        {
            if (configuration == null)
                throw new ArgumentNullException($"{nameof(configuration)} cannot be null.");
            if (connectionOptions == null)
                throw new ArgumentNullException($"{nameof(connectionOptions)} cannot be null.");
            var httpProtocol = new OrientDBHttpConnectionProtocol(connectionOptions);
            return configuration.Connect(httpProtocol);
        }
    }
}
