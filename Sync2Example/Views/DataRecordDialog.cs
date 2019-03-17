using Sync2Example.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sync2Example.Views
{
    public partial class DataRecordDialog : Form
    {
        private readonly SchemaDefinition _schemaDefinition;
        private readonly DynamicEntity _entity;

        public DataRecordDialog(SchemaDefinition schemaDefinition, DynamicEntity entity)
        {
            InitializeComponent();
            _schemaDefinition = schemaDefinition;
            _entity = entity;

            tableLayoutPanel1.VerticalScroll.Maximum = 200;
            InitTableLayout();
        }

        private void InitTableLayout()
        {
            tableLayoutPanel1.Controls.Add(new Label { Text = "Id" }, 0, 0);
            tableLayoutPanel1.Controls.Add(new TextBox { Text = _entity.Id, ReadOnly = true, Dock = DockStyle.Fill }, 1, 0);


            foreach (var column in _schemaDefinition.Columns.Values)
            {
                tableLayoutPanel1.RowCount++;
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                tableLayoutPanel1.Controls.Add(new Label { Text = column.Name }, 0, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new TextBox { Text = _entity.Data[column.Name]?.ToString(), Dock = DockStyle.Fill }, 1, tableLayoutPanel1.RowCount - 1);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CANCELButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
