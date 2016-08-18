using OrientDB.Core.Abstractions;
using System;

namespace OrientDB.ConnectionProtocols.Http
{
    public class OrientDBHttpConnectionProtocol : IOrientDBConnectionProtocol<string>
    {
        private readonly HttpConnectionOptions _options;

        public OrientDBHttpConnectionProtocol(HttpConnectionOptions options)
        {
            _options = options;
        }

        public string ExecuteCommand(string sql)
        {
            throw new NotImplementedException();
        }

        public string ExecuteQuery(string sql)
        {
            throw new NotImplementedException();
        }

        public IOrientDBTransaction NewTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
