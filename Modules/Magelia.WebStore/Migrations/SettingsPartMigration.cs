﻿using Orchard.Data.Migration;
using System;
using System.Data;

namespace Magelia.WebStore.Migrations
{
    public class SettingsPartMigration : DataMigrationImpl
    {
        public Int32 Create()
        {
            this.SchemaBuilder.CreateTable(
                "SettingsPartRecord",
                t => t
                    .ContentPartRecord()
                    .Column("StoreId", DbType.Guid, c => c.NotNull())
                    .Column("ServicesPath", DbType.String, c => c.Unlimited())
                    .Column("AllowRegionNavigation", DbType.Boolean)
            );
            return 1;
        }

        public Int32 UpdateFrom1()
        {
            this.SchemaBuilder.AlterTable(
                "SettingsPartRecord",
                t => t.AddColumn("CacheExpiration", DbType.Int32)
            );
            return 2;
        }
    }
}