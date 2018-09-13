using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmThemNguoiDung : Form
    {
        public frmThemNguoiDung()
        {
            InitializeComponent();
        }

        private void qL_NhomNguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NhomNguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsNguoidung);

        }

        private void frmThemNguoiDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsNguoidung.QL_PhanQuyen' table. You can move, or remove it, as needed.
            this.qL_PhanQuyenTableAdapter.Fill(this.dsNguoidung.QL_PhanQuyen);
            // TODO: This line of code loads data into the 'dsNguoidung.QL_NguoiDungNhomNguoiDung' table. You can move, or remove it, as needed.
            this.qL_NguoiDungNhomNguoiDungTableAdapter.Fill(this.dsNguoidung.QL_NguoiDungNhomNguoiDung);
            // TODO: This line of code loads data into the 'dsNguoidung.QL_NguoiDung' table. You can move, or remove it, as needed.
            this.qL_NguoiDungTableAdapter.Fill(this.dsNguoidung.QL_NguoiDung);
            // TODO: This line of code loads data into the 'dsNguoidung.QL_NhomNguoiDung' table. You can move, or remove it, as needed.
            this.qL_NhomNguoiDungTableAdapter.Fill(this.dsNguoidung.QL_NhomNguoiDung);

        }

        private void fill_DKToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.qL_NguoiDungNhomNguoiDung1TableAdapter.Fill_DK(this.dsNguoidung.QL_NguoiDungNhomNguoiDung1, maNhomNguoiDungToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void qL_NhomNguoiDungComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.qL_NguoiDungNhomNguoiDung1TableAdapter.Fill_DK(this.dsNguoidung.QL_NguoiDungNhomNguoiDung1, qL_NhomNguoiDungComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tenDN = qL_NguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString();
            var maNhom = qL_NhomNguoiDungComboBox.SelectedValue.ToString();
            qL_NguoiDungNhomNguoiDungTableAdapter.Insert(tenDN, maNhom, "");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tenDN = qL_NguoiDungNhomNguoiDung1DataGridView.CurrentRow.Cells[0].Value.ToString();
            var maNhom = qL_NguoiDungNhomNguoiDung1DataGridView.CurrentRow.Cells[1].Value.ToString();
            qL_NguoiDungNhomNguoiDungTableAdapter.DeleteQuery(tenDN, maNhom);
        }
    }
}
