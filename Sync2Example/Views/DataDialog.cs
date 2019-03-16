using Sync2Example.Controllers;
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
        public DataDialog(DataController dataController, ICollection<Models.DynamicEntity> _filteredData)
        {
            InitializeComponent();

            _controller = dataController;
            ViewModel = new DataListViewModel { DynamicEntities = _filteredData };
            DataBindingSource.DataSource = ViewModel;
        }

        private DataController _controller;

        public DataListViewModel ViewModel { get; private set; }

        private void button3_Click(object sender, EventArgs e)
        {
            _controller.DeleteEntity(ViewModel.SelectedDynamicEntity);
        }
    }
}
