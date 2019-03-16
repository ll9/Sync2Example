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
        private DataDialog _view;
        private IEnumerable<DynamicEntity> _filteredData;

        public DataController(string projectTableName, string projectId)
        {
            var syncService = new SyncService();
            var data = syncService.PullData();
            _filteredData = data.Where(d => d.ProjectTable.ProjectId == projectId && d.ProjectTableName == projectTableName);
        }

        public DialogResult ShowDialog()
        {
            _view = new DataDialog(_filteredData.ToList());
            return _view.ShowDialog();
        }
    }
}
