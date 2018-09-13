using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmCauHinh : Form
    {
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        
        public frmCauHinh()
        {
            InitializeComponent();
        }
        private void cboServer_DropDown(object sender, EventArgs e)
        {
            cboServer.DataSource = CauHinh.GetServerName();
            cboServer.DisplayMember = "ServerName";
        }
        

        private void cboDataBase_DropDown(object sender, EventArgs e)
        {
            cboDataBase.DataSource = CauHinh.GetDBName(cboServer.Text, txtUsername.Text, txtPassword.Text);
            cboDataBase.DisplayMember = "name";
        }
        

        private void btnLuu_Click(object sender, EventArgs e)
        {
            CauHinh.SaveConfig(cboServer.Text, txtUsername.Text, txtPassword.Text, cboDataBase.Text);
            this.Close();
        }
       
    }
}
