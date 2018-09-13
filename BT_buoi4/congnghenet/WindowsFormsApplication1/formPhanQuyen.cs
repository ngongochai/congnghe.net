using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.dsNguoidungTableAdapters;

namespace WindowsFormsApplication1
{
    public partial class formPhanQuyen : Form
    {
        public formPhanQuyen()
        {
            InitializeComponent();
        }

        private void qL_NhomNguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NhomNguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsNguoidung);

        }

        private void formPhanQuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsNguoidung.QL_PhanQuyen' table. You can move, or remove it, as needed.
            this.qL_PhanQuyenTableAdapter.Fill(this.dsNguoidung.QL_PhanQuyen);
            // TODO: This line of code loads data into the 'dsNguoidung.QL_PhanQuyen' table. You can move, or remove it, as needed.
            this.qL_PhanQuyenTableAdapter.Fill(this.dsNguoidung.QL_PhanQuyen);
            // TODO: This line of code loads data into the 'dsNguoidung.QL_NhomNguoiDung' table. You can move, or remove it, as needed.
            this.qL_NhomNguoiDungTableAdapter.Fill(this.dsNguoidung.QL_NhomNguoiDung);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.qL_GetPhanQuyenTableAdapter.Fill(this.dsNguoidung.QL_GetPhanQuyen, maNhomNguoiDungToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        public void LoadDataCondition()
        {
            this.qL_GetPhanQuyenTableAdapter.Fill(this.dsNguoidung.QL_GetPhanQuyen,
           qL_NhomNguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString());
        }
        private void qL_NhomNguoiDungDataGridView_SelectionChanged(object sender,
       EventArgs e)
        {
            LoadDataCondition();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string _NhomNguoiDung =
           qL_NhomNguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString();
            foreach (DataGridViewRow item in qL_GetPhanQuyenDataGridView.Rows)
            {
                if (item.Cells[0].Value == null)
                {
                    return;
                }
                var checkKey = qL_PhanQuyenTableAdapter.KiemTraPhanQuyen(_NhomNguoiDung, item.Cells[0].Value.ToString());
                if(checkKey.Count()==0)
                {
                    try
                    {
                        qL_PhanQuyenTableAdapter.Insert(_NhomNguoiDung,
                       item.Cells[0].Value.ToString(), (bool)(item.Cells[2].Value));
                    }
                    catch
                    {
                        qL_PhanQuyenTableAdapter.Insert(_NhomNguoiDung,
                       item.Cells[0].Value.ToString(), false);
                    }
                }
                else
                {
                    qL_PhanQuyenTableAdapter.UpdateQuery((item.Cells[2] == null) ? false
                   : (bool)(item.Cells[2].Value), _NhomNguoiDung, item.Cells[0].Value.ToString());
                }
            }
        }
    }
}
