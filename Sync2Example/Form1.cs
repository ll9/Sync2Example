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
                var dt = new DataTable();
                foreach (var column in schema.Columns.Values)
                {
                    dt.Columns.Add(column.Name, column.DataType);

                }
                var tableItems = data.Where(d => d.ProjectTableName == schema.ProjectTableName);
                foreach (var item in tableItems)
                {
                    var row = dt.NewRow();
                    foreach (var stuff in item.Data)
                    {
                        if (row.Table.Columns.Contains(stuff.Key))
                        {
                            row[stuff.Key] = stuff.Value ?? DBNull.Value;
                        }
                    }
                    dt.Rows.Add(row);
                }


                var grid = new DataGridView();
                grid.DataSource = dt;
                grid.Dock = DockStyle.Fill;
                var tabPage = new TabPage(schema.ProjectTableName);
                tabPage.Controls.Add(grid);
                GridTabControl.TabPages.Add(tabPage);
            }
        }
    }
}
