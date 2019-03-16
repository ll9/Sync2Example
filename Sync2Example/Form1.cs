using Sync2Example.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sync2Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var syncService = new SyncService();

            var schemas = syncService.PullSchemas();
            var data = syncService.PullData();

            foreach (var schema in schemas)
            {
                var dataTable = new DataTable();
                var dynamicEntities = data.Where(d => d.ProjectTableName == schema.ProjectTableName);

                foreach (var column in schema.Columns.Values)
                {
                    dataTable.Columns.Add(column.Name, column.DataType);
                }
                foreach (var dynamicEntity in dynamicEntities)
                {
                    var row = dataTable.NewRow();
                    foreach (var cell in dynamicEntity.Data)
                    {
                        if (row.Table.Columns.Contains(cell.Key))
                        {
                            row[cell.Key] = cell.Value ?? DBNull.Value;
                        }
                    }
                    dataTable.Rows.Add(row);
                }


                var grid = new DataGridView();
                grid.DataSource = dataTable;
                grid.Dock = DockStyle.Fill;
                var tabPage = new TabPage(schema.ProjectTableName);
                tabPage.Controls.Add(grid);
                GridTabControl.TabPages.Add(tabPage);
            }
        }
    }
}
