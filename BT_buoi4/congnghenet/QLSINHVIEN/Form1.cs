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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quanlymonhocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formQLMH qlmh = new formQLMH();
            qlmh.ShowDialog();
        }

        private void quanlykhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }
    }
}
