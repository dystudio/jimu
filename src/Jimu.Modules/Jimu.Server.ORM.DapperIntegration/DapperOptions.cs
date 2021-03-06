﻿using System;

namespace Jimu.Server.ORM.DapperIntegration
{
    public class DapperOptions
    {
        public string ConnectionString { get; set; }
        public DbType DbType { get; set; }
    }

    [Flags]
    public enum DbType
    {
        MySQL = 0,
        SQLServer = 1,
        Oracle = 2,
        PostgreSQL = 3,
        SQLite = 4
    }
}
