namespace SENS_Tools.Forms
{
    partial class frmCreate_ODBC_Scripts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreate_ODBC_Scripts));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiLoadFromConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiLoadFromLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslHeirarchy = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsbGenerate = new System.Windows.Forms.ToolStripSplitButton();
            this.dgvLinks = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tsiSave,
            this.toolStripSeparator1,
            this.tsiExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiLoadFromConfig,
            this.tsiLoadFromLocal});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem1.Text = "Load";
            // 
            // tsiLoadFromConfig
            // 
            this.tsiLoadFromConfig.Name = "tsiLoadFromConfig";
            this.tsiLoadFromConfig.Size = new System.Drawing.Size(182, 22);
            this.tsiLoadFromConfig.Text = "From Configuration";
            this.tsiLoadFromConfig.Click += new System.EventHandler(this.tsiLoadFromConfig_Click);
            // 
            // tsiLoadFromLocal
            // 
            this.tsiLoadFromLocal.Name = "tsiLoadFromLocal";
            this.tsiLoadFromLocal.Size = new System.Drawing.Size(182, 22);
            this.tsiLoadFromLocal.Text = "From Local Machine";
            this.tsiLoadFromLocal.Click += new System.EventHandler(this.tsiLoadFromLocal_Click);
            // 
            // tsiSave
            // 
            this.tsiSave.Name = "tsiSave";
            this.tsiSave.Size = new System.Drawing.Size(100, 22);
            this.tsiSave.Text = "Save";
            this.tsiSave.Click += new System.EventHandler(this.tsiSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // tsiExit
            // 
            this.tsiExit.Name = "tsiExit";
            this.tsiExit.Size = new System.Drawing.Size(100, 22);
            this.tsiExit.Text = "Exit";
            this.tsiExit.Click += new System.EventHandler(this.tsiExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslHeirarchy,
            this.tsbGenerate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 333);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(723, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslHeirarchy
            // 
            this.tslHeirarchy.AutoSize = false;
            this.tslHeirarchy.Name = "tslHeirarchy";
            this.tslHeirarchy.Size = new System.Drawing.Size(70, 17);
            this.tslHeirarchy.Text = "[heirarchy]";
            this.tslHeirarchy.Click += new System.EventHandler(this.tslHeirarchy_Click);
            // 
            // tsbGenerate
            // 
            this.tsbGenerate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbGenerate.AutoSize = false;
            this.tsbGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbGenerate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbGenerate.DropDownButtonWidth = 0;
            this.tsbGenerate.Enabled = false;
            this.tsbGenerate.Image = ((System.Drawing.Image)(resources.GetObject("tsbGenerate.Image")));
            this.tsbGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGenerate.Name = "tsbGenerate";
            this.tsbGenerate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsbGenerate.Size = new System.Drawing.Size(100, 20);
            this.tsbGenerate.Text = "Generate";
            // 
            // dgvLinks
            // 
            this.dgvLinks.AllowUserToOrderColumns = true;
            this.dgvLinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinks.Location = new System.Drawing.Point(12, 27);
            this.dgvLinks.Name = "dgvLinks";
            this.dgvLinks.Size = new System.Drawing.Size(699, 303);
            this.dgvLinks.TabIndex = 3;
            this.dgvLinks.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinks_CellValueChanged);
            this.dgvLinks.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvLinks_CurrentCellDirtyStateChanged);
            // 
            // frmCreate_ODBC_Scripts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 355);
            this.Controls.Add(this.dgvLinks);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCreate_ODBC_Scripts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create ODBC Scripts";
            this.Load += new System.EventHandler(this.frmCreate_ODBC_Scripts_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsiLoadFromConfig;
        private System.Windows.Forms.ToolStripMenuItem tsiLoadFromLocal;
        private System.Windows.Forms.ToolStripMenuItem tsiSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsiExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslHeirarchy;
        private System.Windows.Forms.DataGridView dgvLinks;
        private System.Windows.Forms.ToolStripSplitButton tsbGenerate;
    }
}