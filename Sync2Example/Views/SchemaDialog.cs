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
    public partial class SchemaDialog : Form
    {
        public SchemaDialog(ICollection<SchemaDefinition> schemaDefinitions)
        {
            InitializeComponent();

            ViewModel = new SchemaListViewModel { SchemaDefinitions = schemaDefinitions };
            BindingSource.DataSource = ViewModel;

        }

        public SchemaListViewModel ViewModel { get; }
    }
}
