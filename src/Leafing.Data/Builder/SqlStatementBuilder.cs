﻿using System.Collections.Generic;
using Leafing.Data.Dialect;
using Leafing.Data.SqlEntry;

namespace Leafing.Data.Builder {
    public abstract class SqlStatementBuilder {
        public SqlStatement ToSqlStatement(ModelContext ctx) {
            var sql = ToSqlStatement(ctx.Provider.Dialect, ctx.Info.QueryRequiredFields, ctx.Info.AllowSqlLog);
            return sql;
        }

        public SqlStatement ToSqlStatement(DbDialect dd, List<string> queryRequiredFields, bool needLog = true) {
            var sql = ToSqlStatement(dd, queryRequiredFields);
            sql.NeedLog = needLog;
            return sql;
        }

        protected abstract SqlStatement ToSqlStatement(DbDialect dd, List<string> queryRequiredFields);
    }
}