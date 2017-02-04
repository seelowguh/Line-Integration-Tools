using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SENSToolsLibrary;

namespace SENS_Tools.Forms
{
    public partial class frmCreate_ODBC_Scripts : Form
    {
        public frmCreate_ODBC_Scripts()
        {
            InitializeComponent();
        }

        clsODBCScriptBuilders _odbcBuilder = null;

        private string Hierarchy
        {
            get { return tslHeirarchy.Text; }
            set { tslHeirarchy.Text = value; }
        }

        private List<ODBC> _links;
        private List<ODBC> Links
        {
            get { return _links; }
        }

        private List<ODBC> CommitList;

        private void frmCreate_ODBC_Scripts_Load(object sender, EventArgs e)
        {
            CommitList = new List<ODBC>();
            _links = new List<ODBC>();
            DataGridViewCheckBoxColumn c = new DataGridViewCheckBoxColumn();
            c.ValueType = typeof(bool);
            c.Name = "chk";
            c.HeaderText = "Selected";
            
            dgvLinks.Columns.Add(c);
            foreach(var x in ODBC.GetODBCFields().Where(p => p.ToLower() != "path").OrderBy(p => p).Select(p => p))
            {
                dgvLinks.Columns.Add(x, x);
            }

            dgvLinks.DataSource = _links;
        }


        private void tsiSave_Click(object sender, EventArgs e)
        {
            if (_odbcBuilder == null)
            {
                tslHeirarchy.ForeColor = Color.Red;
                return;
            }

            if(Links.Count > 0)
                _odbcBuilder.Save(Links);
        }

        private void tsiLoadFromConfig_Click(object sender, EventArgs e)
        {

            if (_odbcBuilder == null)
            {
                tslHeirarchy.ForeColor = Color.Red;
                return;
            }

            foreach (var i in _odbcBuilder.GetSaved())
                if (!_links.Contains(i))
                    _links.Add(i);
        }

        private void tsiLoadFromLocal_Click(object sender, EventArgs e)
        {
            if(_odbcBuilder == null)
            {
                tslHeirarchy.ForeColor = Color.Red;
                return;
            }

            foreach (var l in _odbcBuilder.LoadLocalODBCLinks())
                if(!_links.Contains(l))
                    _links.Add(l);
        }

        private void tsiExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to save?", "Save before exit", MessageBoxButtons.YesNoCancel);
            switch (dr)
            {
                case System.Windows.Forms.DialogResult.Yes :
                    //  Save & Exit
                    _odbcBuilder.Save(ExtractODBCDetails(true));
                    Environment.Exit(Environment.ExitCode);
                    break;
                case System.Windows.Forms.DialogResult.No :
                    //  Don't save, just exit
                    Environment.Exit(Environment.ExitCode);
                    break;
                case System.Windows.Forms.DialogResult.Cancel :
                    //  Do nothing
                    break;
            };
        }

        private List<ODBC> ExtractODBCDetails(bool _SelectAll)
        {
            //  If _SelectAll is true, then its for closing and all must be taken, otherwise just return selected.

            return null;
        }

        private void SaveSelected()
        {
            _odbcBuilder.WriteToFile(ExtractODBCDetails(false));
            MessageBox.Show("Complete!", "Saved", MessageBoxButtons.OK);
        }

        private void tslHeirarchy_Click(object sender, EventArgs e)
        {
            _odbcBuilder = null;
            tslHeirarchy.ForeColor = Color.Black;
            switch (Hierarchy)
            {
                case "x64":
                    Hierarchy = "x86";
                    _odbcBuilder = new clsODBCScriptBuilders(false);
                    break;
                case "x86":
                    Hierarchy = "x64";
                    _odbcBuilder = new clsODBCScriptBuilders(true);
                    break;
                default:
                    Hierarchy = "x86";
                    _odbcBuilder = new clsODBCScriptBuilders(false);
                    break;
            };
        }
        
        private void dgvLinks_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvLinks.IsCurrentCellDirty)
                dgvLinks.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvLinks_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0)
                return;

            //  When more than one cell is selected, enable the generate button
            var q = (from DataGridViewRow r in dgvLinks.Rows
                     where Convert.ToBoolean(r.Cells[0].Value) == true
                     select r).Count();

            if (q > 0)
                tsbGenerate.Enabled = true;
            else
                tsbGenerate.Enabled = false;

            //  Find Selected cell and set it up for list of ODBCs
            int i = dgvLinks.Rows[e.RowIndex].Index;
            if (i >= 0)
            {
                // issues here
                bool sel;
                DataGridViewCheckBoxCell cbc = (DataGridViewCheckBoxCell)dgvLinks.Rows[e.RowIndex].Cells[0];

                if (cbc.Value == null)
                    return;

                sel = bool.TryParse(cbc.Value.ToString(), out sel) ? sel : false;

                if (sel == true)
                {
                    //  Checked - add to new list
                    var q_FindLinks = _links.FindAll(c => (c.Name == dgvLinks["Name", e.RowIndex].Value.ToString())
                                    && (c.Server == dgvLinks["Server", e.RowIndex].Value.ToString())
                                    && (c.Database == dgvLinks["Database", e.RowIndex].Value.ToString())
                                    && (c.Driver == dgvLinks["Driver", e.RowIndex].Value.ToString()));

                    foreach(var linkFound in q_FindLinks)
                        CommitList.Add(linkFound);

                }
                else
                {
                    //  Unchecked - remove from new list
                    var q_FindCommit = CommitList.Find(c => (c.Name == dgvLinks["Name", e.RowIndex].Value.ToString())
                                    && (c.Server == dgvLinks["Server", e.RowIndex].Value.ToString())
                                    && (c.Database == dgvLinks["Database", e.RowIndex].Value.ToString())
                                    && (c.Driver == dgvLinks["Driver", e.RowIndex].Value.ToString()));

                    if(q_FindCommit != null)
                        CommitList.Remove(q_FindCommit);
                }
            }
        }
        
    }
}
