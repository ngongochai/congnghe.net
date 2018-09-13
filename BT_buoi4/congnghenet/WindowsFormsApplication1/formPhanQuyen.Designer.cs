namespace WindowsFormsApplication1
{
    partial class formPhanQuyen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.qL_NhomNguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qL_NhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNguoidung = new WindowsFormsApplication1.dsNguoidung();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.qL_GetPhanQuyenDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.qL_GetPhanQuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.maNhomNguoiDungToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.maNhomNguoiDungToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.qL_NhomNguoiDungTableAdapter = new WindowsFormsApplication1.dsNguoidungTableAdapters.QL_NhomNguoiDungTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.dsNguoidungTableAdapters.TableAdapterManager();
            this.qL_GetPhanQuyenTableAdapter = new WindowsFormsApplication1.dsNguoidungTableAdapters.QL_GetPhanQuyenTableAdapter();
            this.qL_PhanQuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_PhanQuyenTableAdapter = new WindowsFormsApplication1.dsNguoidungTableAdapters.QL_PhanQuyenTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNguoidung)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GetPhanQuyenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GetPhanQuyenBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_PhanQuyenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.qL_NhomNguoiDungDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(56, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Nhóm Người Dùng";
            // 
            // qL_NhomNguoiDungDataGridView
            // 
            this.qL_NhomNguoiDungDataGridView.AutoGenerateColumns = false;
            this.qL_NhomNguoiDungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NhomNguoiDungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.qL_NhomNguoiDungDataGridView.DataSource = this.qL_NhomNguoiDungBindingSource;
            this.qL_NhomNguoiDungDataGridView.Location = new System.Drawing.Point(18, 19);
            this.qL_NhomNguoiDungDataGridView.Name = "qL_NhomNguoiDungDataGridView";
            this.qL_NhomNguoiDungDataGridView.Size = new System.Drawing.Size(300, 220);
            this.qL_NhomNguoiDungDataGridView.TabIndex = 0;
            this.qL_NhomNguoiDungDataGridView.SelectionChanged += new System.EventHandler(this.qL_NhomNguoiDungDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNhom";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaNhom";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNhom";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenNhom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.qL_GetPhanQuyenDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(422, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 307);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách quyền chức năng";
            // 
            // qL_GetPhanQuyenDataGridView
            // 
            this.qL_GetPhanQuyenDataGridView.AutoGenerateColumns = false;
            this.qL_GetPhanQuyenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_GetPhanQuyenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.qL_GetPhanQuyenDataGridView.DataSource = this.qL_GetPhanQuyenBindingSource;
            this.qL_GetPhanQuyenDataGridView.Location = new System.Drawing.Point(26, 19);
            this.qL_GetPhanQuyenDataGridView.Name = "qL_GetPhanQuyenDataGridView";
            this.qL_GetPhanQuyenDataGridView.Size = new System.Drawing.Size(361, 220);
            this.qL_GetPhanQuyenDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaManHinh";
            this.dataGridViewTextBoxColumn3.HeaderText = "MaManHinh";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TenManHinh";
            this.dataGridViewTextBoxColumn4.HeaderText = "TenManHinh";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "CoQuyen";
            this.dataGridViewCheckBoxColumn1.HeaderText = "CoQuyen";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // qL_GetPhanQuyenBindingSource
            // 
            this.qL_GetPhanQuyenBindingSource.DataMember = "QL_GetPhanQuyen";
            this.qL_GetPhanQuyenBindingSource.DataSource = this.dsNguoidung;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maNhomNguoiDungToolStripLabel,
            this.maNhomNguoiDungToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(885, 25);
            this.fillToolStrip.TabIndex = 2;
            this.fillToolStrip.Text = "fillToolStrip";
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
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lưu";
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
            this.tableAdapterManager.QL_NguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = this.qL_NhomNguoiDungTableAdapter;
            this.tableAdapterManager.QL_PhanQuyenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.dsNguoidungTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qL_GetPhanQuyenTableAdapter
            // 
            this.qL_GetPhanQuyenTableAdapter.ClearBeforeFill = true;
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
            // formPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formPhanQuyen";
            this.Text = "formPhanQuyen";
            this.Load += new System.EventHandler(this.formPhanQuyen_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNguoidung)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qL_GetPhanQuyenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GetPhanQuyenBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_PhanQuyenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private dsNguoidung dsNguoidung;
        private System.Windows.Forms.BindingSource qL_NhomNguoiDungBindingSource;
        private dsNguoidungTableAdapters.QL_NhomNguoiDungTableAdapter qL_NhomNguoiDungTableAdapter;
        private dsNguoidungTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource qL_GetPhanQuyenBindingSource;
        private dsNguoidungTableAdapters.QL_GetPhanQuyenTableAdapter qL_GetPhanQuyenTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel maNhomNguoiDungToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox maNhomNguoiDungToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView qL_GetPhanQuyenDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView qL_NhomNguoiDungDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource qL_PhanQuyenBindingSource;
        private dsNguoidungTableAdapters.QL_PhanQuyenTableAdapter qL_PhanQuyenTableAdapter;
    }
}