using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SENS_Tools
{
    public partial class frmMenu : Form
    {
        #region SqlFunctions
        public struct SqlFunction
        {
            public int ID;
            public string FormName;
            public string FunctionName;

            public SqlFunction(int _id, string _formName, string _functionName)
            {
                ID = _id;
                FormName = _formName;
                FunctionName = _functionName;
            }
        }
        public List<SqlFunction> SqlFunctions = new List<SqlFunction>();

        private void PopulateSqlFunctions(ref List<SqlFunction> sF)
        {
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (Type t in assembly.GetTypes().Where(x => x.BaseType == typeof(Form) && x.Namespace.StartsWith("SENS")
                    && x.Namespace != Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.Namespace))
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Name = t.UnderlyingSystemType.FullName.Substring(t.Namespace.Length + 4).Replace("_", " ");
                    lvi.Text = lvi.Name;
                    int i = AddListViewItem(lsvMenuOptions, lvi);
                    
                    sF.Add(new SqlFunction(i,
                        t.UnderlyingSystemType.FullName, t.UnderlyingSystemType.FullName.Substring(t.Namespace.Length + 4)));
                }
            }
        }

        private int AddListViewItem(ListView _lv ,ListViewItem _lvi)
        {
            _lv.Items.Add(_lvi);
            return _lv.Items.IndexOf(_lvi);
        }

        private void OpenFunction(int ID)
        {
            if (ID < 0)
                return;

            string formFunctName = SqlFunctions.Find(x => x.ID == ID).FunctionName;
            string formName = SqlFunctions.Find(x => x.ID == ID).FormName;

            try
            {
                Type t = Type.GetType(formName);
                Form frm = (Form)Activator.CreateInstance(t);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error opening form " + formFunctName + ":\t" + ex.Message);
            }

        }

        #endregion

        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            PopulateSqlFunctions(ref SqlFunctions);
        }

        private void lsvMenuOptions_SelectedIndexChanged(object sender, MouseEventArgs e)
        {
            if (lsvMenuOptions.SelectedItems[0].Index > -1 && lsvMenuOptions.SelectedItems[0].Index != null)
            {
                OpenFunction(lsvMenuOptions.SelectedItems[0].Index);
            }
        }

    }
}
