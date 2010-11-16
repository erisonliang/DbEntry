﻿using System.Data;
using System.Data.Common;
using System.Data.OracleClient;
using Lephone.Data.SqlEntry;

namespace Lephone.Data.Driver
{
    internal class Oracle8Driver : DbDriver
    {
        public Oracle8Driver(Dialect.DbDialect dialectClass, string connectionString, string dbProviderFactoryName, bool autoCreateTable)
            : base(dialectClass, connectionString, dbProviderFactoryName, autoCreateTable)
		{
		}

        protected override DbProviderFactory GetDefaultProviderFactory()
        {
            return  OracleClientFactory.Instance;
        }

        protected override void DeriveParameters(IDbCommand e)
        {
            OracleCommandBuilder.DeriveParameters((OracleCommand)e);
        }

		public override IDbDataParameter GetDbParameter(DataParameter dp)
		{
            var odp = (OracleParameter)base.GetDbParameter(dp);
            if (dp.Type == DataType.String)
            {
                odp.OracleType = OracleType.VarChar;
            }
            else
            {
                odp.DbType = (DbType)dp.Type;
            }
			return odp;
		}
    }
}