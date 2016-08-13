using OrientDB.Core.Abstractions;
using System;

namespace OrientDB.ConnectionProtocols.Http
{
    public class OrientDBHttpConnectionProtocol : IOrientDBConnectionProtocol
    {
        private readonly HttpConnectionOptions _options;

        public OrientDBHttpConnectionProtocol(HttpConnectionOptions options)
        {
            _options = options;
        }

        public byte[] ExecuteCommand(string sql)
        {
            throw new NotImplementedException();
        }

        public byte[] ExecuteQuery(string sql)
        {
            throw new NotImplementedException();
        }

        public IOrientDBTransaction NewTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
