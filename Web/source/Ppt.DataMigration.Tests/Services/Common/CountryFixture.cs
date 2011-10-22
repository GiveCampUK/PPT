using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Ppt.DataMigration.Tests.Services.Common
{
    [TestFixture]
    public class CountryFixture
    {
        SqlConnection _sqlConnection;
        OleDbConnection _oleConnection;

        public void Setup()
        {
            _sqlConnection = new SqlConnection(Global.SqlConn);
            _oleConnection = new OleDbConnection(Global.AccessConn);
        }
    }
}
