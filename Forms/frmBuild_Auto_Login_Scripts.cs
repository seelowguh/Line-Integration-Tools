using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SENSToolsLibrary;


namespace SENS_Tools.Forms
{
    public partial class frmBuild_Auto_Login_Scripts : Form
    {
        public frmBuild_Auto_Login_Scripts()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtOutputFolder.Text == string.Empty)
            {
                txtOutputFolder.Text = "Double click to select folder.";
                txtOutputFolder.ForeColor = Color.LightGray;
            }
            else
            {
                txtOutputFolder.ForeColor = Color.Black;
            }
        }

        private void txtOutputFolder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FolderBrowserDialog fldBrowserDialog = new FolderBrowserDialog();
            if (fldBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtOutputFolder.Text = fldBrowserDialog.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtOutputFolder.Text == string.Empty)
            {
                MessageBox.Show("Output Folder is blank");
                return;
            }

            if (!Directory.Exists(txtOutputFolder.Text))
            {
                MessageBox.Show("Directory doesn't exist.");
                return;
            }
            
            clsTextFileBuilders clsTFB = new clsTextFileBuilders(txtOutputFolder.Text);

            try
            {
                foreach (string line in txtDetails.Lines)
                {
                    string[] fields = line.Split(',');
                    if (fields.Length == 3)
                    {
                        clsTFB.BuildLoginScript(fields[1], fields[2], fields[0]);
                    }
                }
                Process.Start(txtOutputFolder.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtOutputFolder_Click(object sender, EventArgs e)
        {
            
        }

        private void frmBuild_Auto_Login_Scripts_Load_1(object sender, EventArgs e)
        {
            txtOutputFolder.Text = "Double click to select folder.";
            txtOutputFolder.ForeColor = Color.LightGray;
        }
    }
}
