using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSINHVIEN
{
    public partial class formQLKHOA : Form
    {
        QLSVDataContext qlsv = new QLSVDataContext();
        public formQLKHOA()
        {
            InitializeComponent();
            txtMaKhoa.Enabled = false;
            txtTenKhoa.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnluu.Enabled = false; 
        }
        private List<Khoa> getAllKhoa()
        {
            var listKhoa = from khoa1 in qlsv.Khoas select khoa1;
            return listKhoa.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Enabled = true;
            txtTenKhoa.Enabled = true;
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            btnluu.Enabled = true;
            txtMaKhoa.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = true;
            txtMaKhoa.Enabled = false;
            txtTenKhoa.Enabled = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            Khoa khoa = new Khoa();
            
            if (txtMaKhoa.Text == "")
            {
                MessageBox.Show("Mã khoa không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTenKhoa.Text == "")
            {
                MessageBox.Show("Tên khoa không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var checkMakhoa = qlsv.Khoas.Where(a => a.MaKhoa == txtMaKhoa.Text.Trim()).FirstOrDefault();
            if (checkMakhoa == null)
            {
                khoa.MaKhoa = txtMaKhoa.Text.Trim();
                khoa.TenKhoa = txtTenKhoa.Text.Trim();
                qlsv.Khoas.InsertOnSubmit(khoa);
                qlsv.SubmitChanges();
            }
            else
            {
                checkMakhoa.TenKhoa = txtTenKhoa.Text.Trim();
                qlsv.SubmitChanges();
            }
            txtMaKhoa.Enabled = txtTenKhoa.Enabled = false;
            khoaDataGridView.DataSource = this.getAllKhoa();
        }

        private void formQLKHOA_Load(object sender, EventArgs e)
        {
            khoaDataGridView.DataSource = qlsv.Khoas.Select(sv => sv);
        }

        private void khoaDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (khoaDataGridView.CurrentRow.Cells[0].Value != null)
            {
                string makhoa = khoaDataGridView.CurrentRow.Cells[0].Value.ToString();
                Khoa khoa = qlsv.Khoas.Where(a => a.MaKhoa == makhoa).FirstOrDefault();
                if (khoa != null)
                {
                    txtMaKhoa.Text = khoa.MaKhoa;
                    txtTenKhoa.Text = khoa.TenKhoa;
                    btnsua.Enabled = true;
                    btnxoa.Enabled = true;
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string makhoa = khoaDataGridView.CurrentRow.Cells[0].Value.ToString();
            Khoa khoa = qlsv.Khoas.Where(a => a.MaKhoa == makhoa).FirstOrDefault();
            qlsv.Khoas.DeleteOnSubmit(khoa);
            qlsv.SubmitChanges();
            khoaDataGridView.DataSource = this.getAllKhoa();
        }
    }
}
