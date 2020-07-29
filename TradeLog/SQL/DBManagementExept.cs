using System;
using System.Runtime.Serialization;

namespace TradeLog.SQL
{
    [Serializable]
    internal class DBManagementExept : Exception
    {

        public DBManagementExept(string message, Exception innerException) : base(message, innerException)
        {
            ExeptionLog.Bejegyzes(this);
        }

    }
}