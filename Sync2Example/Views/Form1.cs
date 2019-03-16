using Sync2Example.Models;
using Sync2Example.Services;
using Sync2Example.Views;
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

                dataTable.Columns.Add(nameof(DynamicEntity.Id), typeof(string));
                dataTable.Columns.Add(nameof(DynamicEntity.IsDeleted), typeof(bool));
                dataTable.Columns.Add(nameof(DynamicEntity.SyncStatus), typeof(bool));
                dataTable.Columns.Add(nameof(DynamicEntity.RowVersion), typeof(int));
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
                    row[nameof(DynamicEntity.Id)] = dynamicEntity.Id;
                    row[nameof(DynamicEntity.IsDeleted)] = dynamicEntity.IsDeleted;
                    row[nameof(DynamicEntity.SyncStatus)] = dynamicEntity.SyncStatus;
                    row[nameof(DynamicEntity.RowVersion)] = dynamicEntity.RowVersion;
                    dataTable.Rows.Add(row);
                }


                var grid = new DataGridView();
                grid.ReadOnly = true;
                grid.DataSource = dataTable;
                grid.Dock = DockStyle.Fill;
                var tabPage = new TabPage(schema.ProjectTableName);
                tabPage.Controls.Add(grid);
                GridTabControl.TabPages.Add(tabPage);
            }
        }

        private void CRUDButton_Click(object sender, EventArgs e)
        {
            var syncService = new SyncService();

            var schemas = syncService.PullSchemas();
            new SchemaDialog(schemas.ToList()).ShowDialog();
        }
    }
}
