using Sync2Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sync2Example.ViewModels
{
    public class DataListViewModel
    {
        public ICollection<DynamicEntity> DynamicEntities { get; set; }
        public DynamicEntity SelectedDynamicEntity { get; set; }
    }
}
