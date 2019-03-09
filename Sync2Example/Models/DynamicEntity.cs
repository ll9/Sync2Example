﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sync2Example.Models
{
    public class DynamicEntity
    {
        public DynamicEntity()
        {

        }

        public DynamicEntity(DataRow row, ProjectTable projectTable)
        {
            ProjectTable = projectTable;
            ProjectTableName = projectTable.Name;
            Id = row.Field<string>(nameof(Id));
            SyncStatus = row.Field<bool>(nameof(SyncStatus));
            IsDeleted = row.Field<bool>(nameof(IsDeleted));
            RowVersion = (int)row.Field<long>(nameof(RowVersion));
            Data = row.Table.Columns
              .Cast<DataColumn>()
              .ToDictionary(c => c.ColumnName, c => row[c]);
        }

        public string Id { get; set; }
        public bool SyncStatus { get; set; }
        public bool IsDeleted { get; set; }
        public int RowVersion { get; set; }
        public Dictionary<string, object> Data { get; set; }
        public ProjectTable ProjectTable { get; set; }
        public string ProjectTableName { get; set; }

        public static IEnumerable<string> GetSyncEntityNames()
        {
            return new[]
            {
                nameof(Id),
                nameof(SyncStatus),
                nameof(IsDeleted),
                nameof(RowVersion),
                nameof(ProjectTable),
                nameof(ProjectTableName),
            };
        }
    }
}
