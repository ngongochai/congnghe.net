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
    public partial class formQLMH : Form
    {
        QLSVDataContext qlsv = new QLSVDataContext();
        public formQLMH()
        {
            InitializeComponent();
            var monhocs = getAllMonHoc();
            datagvMonHoc.DataSource = monhocs;
        }
        private List<MonHoc> getAllMonHoc()
        {
            var monhocs = from mh1 in qlsv.MonHocs select mh1;
            datagvMonHoc.DataSource = monhocs;
            return monhocs.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MonHoc mh = new MonHoc();
            if (txtMaMonHoc.Text == "")
            {
                MessageBox.Show("Mã môn học không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTenMonHoc.Text == "")
            {
                MessageBox.Show("Tên môn học không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            mh.MaMonHoc = txtMaMonHoc.Text;
            mh.TenMonHoc = txtTenMonHoc.Text;
            var checkMaMonHoc = qlsv.MonHocs.Where(a => a.MaMonHoc == mh.MaMonHoc).FirstOrDefault();
            if (checkMaMonHoc != null)
            {
                MessageBox.Show("Mã môn học đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            qlsv.MonHocs.InsertOnSubmit(mh);
            qlsv.SubmitChanges();
            var monhocs = from mh1 in qlsv.MonHocs select mh1;
            datagvMonHoc.DataSource = monhocs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mamh = datagvMonHoc.CurrentRow.Cells[0].Value.ToString();
            MonHoc monHoc = qlsv.MonHocs.Where(a => a.MaMonHoc == mamh).FirstOrDefault();
            qlsv.MonHocs.DeleteOnSubmit(monHoc);
            qlsv.SubmitChanges();
            var monhocs = from mh1 in qlsv.MonHocs select mh1;
            datagvMonHoc.DataSource = monhocs;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mamh = datagvMonHoc.CurrentRow.Cells[0].Value.ToString();
            MonHoc monHoc = qlsv.MonHocs.Where(a => a.MaMonHoc == mamh).FirstOrDefault();
            if (txtMaMonHoc.Text == "")
            {
                MessageBox.Show("Mã môn học không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTenMonHoc.Text == "")
            {
                MessageBox.Show("Tên môn học không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            monHoc.MaMonHoc = txtMaMonHoc.Text;
            monHoc.TenMonHoc = txtTenMonHoc.Text;
            qlsv.SubmitChanges();
            var monhocs = from mh1 in qlsv.MonHocs select mh1;
            datagvMonHoc.DataSource = monhocs;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formQLMH qlmh = new formQLMH();
            qlmh.Close();
        }

        private void datagvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string mamh = datagvMonHoc.CurrentRow.Cells[0].Value.ToString();
            MonHoc monHoc = qlsv.MonHocs.Where(a => a.MaMonHoc == mamh).FirstOrDefault();
            txtMaMonHoc.Text = monHoc.MaMonHoc;
            txtTenMonHoc.Text = monHoc.TenMonHoc;
        }

    }
}
