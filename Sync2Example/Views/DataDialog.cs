using Sync2Example.Controllers;
using Sync2Example.Models;
using Sync2Example.ViewModels;
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
    public partial class DataDialog : Form
    {
        public DataDialog(DataController dataController, List<DynamicEntity> list, SchemaDefinition schemaDefinition)
        {
            InitializeComponent();

            _controller = dataController;
            ViewModel = new DataListViewModel { DynamicEntities = list };
            DataBindingSource.DataSource = ViewModel;
            _schemaDefinition = schemaDefinition;
        }

        private DataController _controller;
        private SchemaDefinition _schemaDefinition;

        public DataListViewModel ViewModel { get; private set; }

        private void button3_Click(object sender, EventArgs e)
        {
            _controller.DeleteEntity(ViewModel.SelectedDynamicEntity);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var dialog = new DataRecordDialog(_schemaDefinition, ViewModel.SelectedDynamicEntity);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _controller.EditEntity(ViewModel.SelectedDynamicEntity);
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create not implemented yet");
        }
    }
}
