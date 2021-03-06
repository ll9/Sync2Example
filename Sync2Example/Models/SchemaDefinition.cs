﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sync2Example.Models
{
    public class SchemaDefinition
    {
        public string Id { get; set; }
        public Dictionary<string, Column> Columns { get; set; }

        public ProjectTable ProjectTable { get; set; }
        public string ProjectTableName { get; set; }

        public bool SyncStatus { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        public int RowVersion { get; set; } = 0;
    }
}
