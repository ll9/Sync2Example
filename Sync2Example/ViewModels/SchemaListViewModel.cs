using Sync2Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sync2Example.ViewModels
{
    public class SchemaListViewModel
    {
        public ICollection<SchemaDefinition> SchemaDefinitions { get; set; }
        public SchemaDefinition SelectedSchemaDefinition { get; set; }
    }
}
