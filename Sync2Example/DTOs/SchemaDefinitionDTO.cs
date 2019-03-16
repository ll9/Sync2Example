using Sync2Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sync2Example.DTOs
{
    class SchemaDefinitionDTO
    {
        public string Id { get; set; }
        public Dictionary<string, Column> Columns { get; set; }

        public bool IsDeleted { get; set; }
        public int RowVersion { get; set; }

        public string ProjectTableName { get; set; }
        public string ProjectId { get; set; }
    }
}
