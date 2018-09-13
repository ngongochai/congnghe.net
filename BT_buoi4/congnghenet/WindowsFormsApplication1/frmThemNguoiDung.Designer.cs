namespace WindowsFormsApplication1
{
    partial class frmThemNguoiDung
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
            this.components = new System.ComponentModel.Container();
            this.qL_NhomNguoiDungComboBox = new System.Windows.Forms.ComboBox();
            this.qL_NhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNguoidung = new WindowsFormsApplication1.dsNguoidung();
            this.qL_NguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.qL_NguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fill_DKToolStrip = new System.Windows.Forms.ToolStrip();
            this.maNhomNguoiDungToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.maNhomNguoiDungToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fill_DKToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.qL_NguoiDungNhomNguoiDung1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qL_NguoiDungNhomNguoiDung1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.qL_NhomNguoiDungTableAdapter = new WindowsFormsApplication1.dsNguoidungTableAdapters.QL_NhomNguoiDungTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.dsNguoidungTableAdapters.TableAdapterManager();
            this.qL_NguoiDungTableAdapter = new WindowsFormsApplication1.dsNguoidungTableAdapters.QL_NguoiDungTableAdapter();
            this.qL_NhomNguoiDungBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NguoiDungNhomNguoiDung1TableAdapter = new WindowsFormsApplication1.dsNguoidungTableAdapters.QL_NguoiDungNhomNguoiDung1TableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.qL_NguoiDungNhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NguoiDungNhomNguoiDungTableAdapter = new WindowsFormsApplication1.dsNguoidungTableAdapters.QL_NguoiDungNhomNguoiDungTableAdapter();
            this.qL_PhanQuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_PhanQuyenTableAdapter = new WindowsFormsApplication1.dsNguoidungTableAdapters.QL_PhanQuyenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNguoidung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingSource)).BeginInit();
            this.fill_DKToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDung1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDung1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_PhanQuyenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // qL_NhomNguoiDungComboBox
            // 
            this.qL_NhomNguoiDungComboBox.DataSource = this.qL_NhomNguoiDungBindingSource;
            this.qL_NhomNguoiDungComboBox.DisplayMember = "TenNhom";
            this.qL_NhomNguoiDungComboBox.FormattingEnabled = true;
            this.qL_NhomNguoiDungComboBox.Location = new System.Drawing.Point(366, 28);
            this.qL_NhomNguoiDungComboBox.Name = "qL_NhomNguoiDungComboBox";
            this.qL_NhomNguoiDungComboBox.Size = new System.Drawing.Size(216, 21);
            this.qL_NhomNguoiDungComboBox.TabIndex = 0;
            this.qL_NhomNguoiDungComboBox.ValueMember = "MaNhom";
            this.qL_NhomNguoiDungComboBox.SelectedIndexChanged += new System.EventHandler(this.qL_NhomNguoiDungComboBox_SelectedIndexChanged);
            // 
            // qL_NhomNguoiDungBindingSource
            // 
            this.qL_NhomNguoiDungBindingSource.DataMember = "QL_NhomNguoiDung";
            this.qL_NhomNguoiDungBindingSource.DataSource = this.dsNguoidung;
            // 
            // dsNguoidung
            // 
            this.dsNguoidung.DataSetName = "dsNguoidung";
            this.dsNguoidung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qL_NguoiDungDataGridView
            // 
            this.qL_NguoiDungDataGridView.AutoGenerateColumns = false;
            this.qL_NguoiDungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NguoiDungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.qL_NguoiDungDataGridView.DataSource = this.qL_NguoiDungBindingSource;
            this.qL_NguoiDungDataGridView.Location = new System.Drawing.Point(31, 79);
            this.qL_NguoiDungDataGridView.Name = "qL_NguoiDungDataGridView";
            this.qL_NguoiDungDataGridView.Size = new System.Drawing.Size(346, 226);
            this.qL_NguoiDungDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenDangNhap";
            this.dataGridViewTextBoxColumn1.HeaderText = "TenDangNhap";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MatKhau";
            this.dataGridViewTextBoxColumn2.HeaderText = "MatKhau";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "HoatDong";
            this.dataGridViewCheckBoxColumn1.HeaderText = "HoatDong";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // qL_NguoiDungBindingSource
            // 
            this.qL_NguoiDungBindingSource.DataMember = "QL_NguoiDung";
            this.qL_NguoiDungBindingSource.DataSource = this.dsNguoidung;
            // 
            // fill_DKToolStrip
            // 
            this.fill_DKToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maNhomNguoiDungToolStripLabel,
            this.maNhomNguoiDungToolStripTextBox,
            this.fill_DKToolStripButton});
            this.fill_DKToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fill_DKToolStrip.Name = "fill_DKToolStrip";
            this.fill_DKToolStrip.Size = new System.Drawing.Size(848, 25);
            this.fill_DKToolStrip.TabIndex = 2;
            this.fill_DKToolStrip.Text = "fill_DKToolStrip";
            // 
            // maNhomNguoiDungToolStripLabel
            // 
            this.maNhomNguoiDungToolStripLabel.Name = "maNhomNguoiDungToolStripLabel";
            this.maNhomNguoiDungToolStripLabel.Size = new System.Drawing.Size(123, 22);
            this.maNhomNguoiDungToolStripLabel.Text = "MaNhomNguoiDung:";
            // 
            // maNhomNguoiDungToolStripTextBox
            // 
            this.maNhomNguoiDungToolStripTextBox.Name = "maNhomNguoiDungToolStripTextBox";
            this.maNhomNguoiDungToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fill_DKToolStripButton
            // 
            this.fill_DKToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fill_DKToolStripButton.Name = "fill_DKToolStripButton";
            this.fill_DKToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.fill_DKToolStripButton.Text = "Fill_DK";
            this.fill_DKToolStripButton.Click += new System.EventHandler(this.fill_DKToolStripButton_Click);
            // 
            // qL_NguoiDungNhomNguoiDung1DataGridView
            // 
            this.qL_NguoiDungNhomNguoiDung1DataGridView.AutoGenerateColumns = false;
            this.qL_NguoiDungNhomNguoiDung1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NguoiDungNhomNguoiDung1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.qL_NguoiDungNhomNguoiDung1DataGridView.DataSource = this.qL_NguoiDungNhomNguoiDung1BindingSource;
            this.qL_NguoiDungNhomNguoiDung1DataGridView.Location = new System.Drawing.Point(465, 79);
            this.qL_NguoiDungNhomNguoiDung1DataGridView.Name = "qL_NguoiDungNhomNguoiDung1DataGridView";
            this.qL_NguoiDungNhomNguoiDung1DataGridView.Size = new System.Drawing.Size(342, 220);
            this.qL_NguoiDungNhomNguoiDung1DataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TenDangNhap";
            this.dataGridViewTextBoxColumn3.HeaderText = "TenDangNhap";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaNhomNguoiDung";
            this.dataGridViewTextBoxColumn4.HeaderText = "MaNhomNguoiDung";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn5.HeaderText = "GhiChu";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // qL_NguoiDungNhomNguoiDung1BindingSource
            // 
            this.qL_NguoiDungNhomNguoiDung1BindingSource.DataMember = "QL_NguoiDungNhomNguoiDung1";
            this.qL_NguoiDungNhomNguoiDung1BindingSource.DataSource = this.dsNguoidung;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Them";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // qL_NhomNguoiDungTableAdapter
            // 
            this.qL_NhomNguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDung1TableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungTableAdapter = this.qL_NguoiDungTableAdapter;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = this.qL_NhomNguoiDungTableAdapter;
            this.tableAdapterManager.QL_PhanQuyenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.dsNguoidungTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qL_NguoiDungTableAdapter
            // 
            this.qL_NguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // qL_NhomNguoiDungBindingSource1
            // 
            this.qL_NhomNguoiDungBindingSource1.DataMember = "QL_NhomNguoiDung";
            this.qL_NhomNguoiDungBindingSource1.DataSource = this.dsNguoidung;
            // 
            // qL_NguoiDungNhomNguoiDung1TableAdapter
            // 
            this.qL_NguoiDungNhomNguoiDung1TableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Xoa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // qL_NguoiDungNhomNguoiDungBindingSource
            // 
            this.qL_NguoiDungNhomNguoiDungBindingSource.DataMember = "QL_NguoiDungNhomNguoiDung";
            this.qL_NguoiDungNhomNguoiDungBindingSource.DataSource = this.dsNguoidung;
            // 
            // qL_NguoiDungNhomNguoiDungTableAdapter
            // 
            this.qL_NguoiDungNhomNguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // qL_PhanQuyenBindingSource
            // 
            this.qL_PhanQuyenBindingSource.DataMember = "QL_PhanQuyen";
            this.qL_PhanQuyenBindingSource.DataSource = this.dsNguoidung;
            // 
            // qL_PhanQuyenTableAdapter
            // 
            this.qL_PhanQuyenTableAdapter.ClearBeforeFill = true;
            // 
            // frmThemNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 375);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.qL_NguoiDungNhomNguoiDung1DataGridView);
            this.Controls.Add(this.fill_DKToolStrip);
            this.Controls.Add(this.qL_NguoiDungDataGridView);
            this.Controls.Add(this.qL_NhomNguoiDungComboBox);
            this.Name = "frmThemNguoiDung";
            this.Text = "frmThemNguoiDung";
            this.Load += new System.EventHandler(this.frmThemNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNguoidung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingSource)).EndInit();
            this.fill_DKToolStrip.ResumeLayout(false);
            this.fill_DKToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDung1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDung1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_PhanQuyenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsNguoidung dsNguoidung;
        private System.Windows.Forms.BindingSource qL_NhomNguoiDungBindingSource;
        private dsNguoidungTableAdapters.QL_NhomNguoiDungTableAdapter qL_NhomNguoiDungTableAdapter;
        private dsNguoidungTableAdapters.TableAdapterManager tableAdapterManager;
        private dsNguoidungTableAdapters.QL_NguoiDungTableAdapter qL_NguoiDungTableAdapter;
        private System.Windows.Forms.BindingSource qL_NhomNguoiDungBindingSource1;
        private System.Windows.Forms.ComboBox qL_NhomNguoiDungComboBox;
        private System.Windows.Forms.BindingSource qL_NguoiDungBindingSource;
        private System.Windows.Forms.DataGridView qL_NguoiDungDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource qL_NguoiDungNhomNguoiDung1BindingSource;
        private dsNguoidungTableAdapters.QL_NguoiDungNhomNguoiDung1TableAdapter qL_NguoiDungNhomNguoiDung1TableAdapter;
        private System.Windows.Forms.ToolStrip fill_DKToolStrip;
        private System.Windows.Forms.ToolStripLabel maNhomNguoiDungToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox maNhomNguoiDungToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fill_DKToolStripButton;
        private System.Windows.Forms.DataGridView qL_NguoiDungNhomNguoiDung1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource qL_NguoiDungNhomNguoiDungBindingSource;
        private dsNguoidungTableAdapters.QL_NguoiDungNhomNguoiDungTableAdapter qL_NguoiDungNhomNguoiDungTableAdapter;
        private System.Windows.Forms.BindingSource qL_PhanQuyenBindingSource;
        private dsNguoidungTableAdapters.QL_PhanQuyenTableAdapter qL_PhanQuyenTableAdapter;
    }
}