using Sync2Example.Models;
using Sync2Example.Services;
using Sync2Example.ViewModels;
using Sync2Example.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sync2Example.Controllers
{
    public class DataController
    {
        private readonly SchemaDefinition _schemaDefinition;
        private DataDialog _view;
        private IEnumerable<DynamicEntity> _filteredData;

        public DataController(SchemaDefinition schemaDefinition)
        {
            var syncService = new SyncService();
            var data = syncService.PullData();
            _filteredData = data.Where(d => d.ProjectTable.ProjectId == schemaDefinition.ProjectTable.ProjectId && d.ProjectTableName == schemaDefinition.ProjectTableName);
            this._schemaDefinition = schemaDefinition;
        }

        public DialogResult ShowDialog()
        {
            _view = new DataDialog(this, _filteredData.ToList(), _schemaDefinition);
            return _view.ShowDialog();
        }

        internal void DeleteEntity(DynamicEntity selectedDynamicEntity)
        {
            selectedDynamicEntity.IsDeleted = true;
            selectedDynamicEntity.SyncStatus = false;

            var syncService = new SyncService();
            syncService.DeleteEntity(selectedDynamicEntity);
        }

        internal void EditEntity(DynamicEntity selectedDynamicEntity)
        {
            selectedDynamicEntity.SyncStatus = false;
            var syncService = new SyncService();
            syncService.EditEntity(selectedDynamicEntity);
        }
    }
}
