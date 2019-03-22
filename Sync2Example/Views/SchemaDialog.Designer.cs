namespace Sync2Example.Views
{
    partial class SchemaDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ChooseButton = new System.Windows.Forms.Button();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BindingSource, "SelectedSchemaDefinition", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.BindingSource, "SchemaDefinitions", true));
            this.listBox1.DisplayMember = "ProjectTableNameWithId";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(402, 186);
            this.listBox1.TabIndex = 0;
            // 
            // ChooseButton
            // 
            this.ChooseButton.Location = new System.Drawing.Point(13, 232);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(75, 23);
            this.ChooseButton.TabIndex = 1;
            this.ChooseButton.Text = "Auswählen";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // BindingSource
            // 
            this.BindingSource.DataSource = typeof(Sync2Example.ViewModels.SchemaListViewModel);
            // 
            // SchemaDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 278);
            this.Controls.Add(this.ChooseButton);
            this.Controls.Add(this.listBox1);
            this.Name = "SchemaDialog";
            this.Text = "SchemaDialog";
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ChooseButton;
        private System.Windows.Forms.BindingSource BindingSource;
    }
}