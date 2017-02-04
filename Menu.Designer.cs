namespace SENS_Tools
{
    partial class frmMenu
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
            this.lsvMenuOptions = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lsvMenuOptions
            // 
            this.lsvMenuOptions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvMenuOptions.Location = new System.Drawing.Point(13, 13);
            this.lsvMenuOptions.MaximumSize = new System.Drawing.Size(359, 337);
            this.lsvMenuOptions.MinimumSize = new System.Drawing.Size(359, 337);
            this.lsvMenuOptions.MultiSelect = false;
            this.lsvMenuOptions.Name = "lsvMenuOptions";
            this.lsvMenuOptions.Size = new System.Drawing.Size(359, 337);
            this.lsvMenuOptions.TabIndex = 0;
            this.lsvMenuOptions.UseCompatibleStateImageBehavior = false;
            this.lsvMenuOptions.View = System.Windows.Forms.View.List;
            this.lsvMenuOptions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvMenuOptions_SelectedIndexChanged);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.lsvMenuOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tools Menu - Double Click Option";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvMenuOptions;

    }
}

