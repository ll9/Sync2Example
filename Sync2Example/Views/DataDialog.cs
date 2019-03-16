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
        public DataDialog(ICollection<Models.DynamicEntity> _filteredData)
        {
            InitializeComponent();

            ViewModel = new DataListViewModel { DynamicEntities = _filteredData };
            DataBindingSource.DataSource = ViewModel;
        }

        public DataListViewModel ViewModel { get; private set; }
    }
}
