namespace Sync2Example
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridTabControl = new System.Windows.Forms.TabControl();
            this.CRUDButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GridTabControl
            // 
            this.GridTabControl.Location = new System.Drawing.Point(22, 13);
            this.GridTabControl.Name = "GridTabControl";
            this.GridTabControl.SelectedIndex = 0;
            this.GridTabControl.Size = new System.Drawing.Size(741, 307);
            this.GridTabControl.TabIndex = 0;
            // 
            // CRUDButton
            // 
            this.CRUDButton.Location = new System.Drawing.Point(688, 363);
            this.CRUDButton.Name = "CRUDButton";
            this.CRUDButton.Size = new System.Drawing.Size(75, 23);
            this.CRUDButton.TabIndex = 1;
            this.CRUDButton.Text = "CRUD";
            this.CRUDButton.UseVisualStyleBackColor = true;
            this.CRUDButton.Click += new System.EventHandler(this.CRUDButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CRUDButton);
            this.Controls.Add(this.GridTabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl GridTabControl;
        private System.Windows.Forms.Button CRUDButton;
    }
}

