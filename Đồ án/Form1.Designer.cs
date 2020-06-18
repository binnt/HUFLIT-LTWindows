namespace Đồ_án
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.GbTimKiem = new System.Windows.Forms.GroupBox();
            this.BtTimKiemTheoHoTen = new System.Windows.Forms.Button();
            this.BtTimKiemMaPhong = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lBHoTen = new System.Windows.Forms.Label();
            this.LbMaPhong = new System.Windows.Forms.Label();
            this.gBThanhtoan = new System.Windows.Forms.GroupBox();
            this.BtTinhTien = new System.Windows.Forms.Button();
            this.bTthoat = new System.Windows.Forms.Button();
            this.lBphongKhachO = new System.Windows.Forms.Label();
            this.LBSoNgayKhachO = new System.Windows.Forms.Label();
            this.lBTongTienPhaiThanhToan = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.chiTietKHDataSet = new Đồ_án.ChiTietKHDataSet();
            this.tableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Đồ_án.ChiTietKHDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Đồ_án.ChiTietKHDataSetTableAdapters.TableAdapterManager();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBChiTietKHTT = new System.Windows.Forms.GroupBox();
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GbTimKiem.SuspendLayout();
            this.gBThanhtoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietKHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.gBChiTietKHTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ KHÁCH SẠN MINI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GbTimKiem
            // 
            this.GbTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GbTimKiem.Controls.Add(this.BtTimKiemTheoHoTen);
            this.GbTimKiem.Controls.Add(this.BtTimKiemMaPhong);
            this.GbTimKiem.Controls.Add(this.comboBox2);
            this.GbTimKiem.Controls.Add(this.comboBox1);
            this.GbTimKiem.Controls.Add(this.lBHoTen);
            this.GbTimKiem.Controls.Add(this.LbMaPhong);
            this.GbTimKiem.Location = new System.Drawing.Point(12, 55);
            this.GbTimKiem.Name = "GbTimKiem";
            this.GbTimKiem.Size = new System.Drawing.Size(437, 110);
            this.GbTimKiem.TabIndex = 1;
            this.GbTimKiem.TabStop = false;
            this.GbTimKiem.Text = "Tìm kiếm nhanh";
            this.GbTimKiem.Enter += new System.EventHandler(this.GbTimKiem_Enter);
            // 
            // BtTimKiemTheoHoTen
            // 
            this.BtTimKiemTheoHoTen.Location = new System.Drawing.Point(256, 64);
            this.BtTimKiemTheoHoTen.Name = "BtTimKiemTheoHoTen";
            this.BtTimKiemTheoHoTen.Size = new System.Drawing.Size(144, 23);
            this.BtTimKiemTheoHoTen.TabIndex = 5;
            this.BtTimKiemTheoHoTen.Text = "Tìm kiếm theo họ tên";
            this.BtTimKiemTheoHoTen.UseVisualStyleBackColor = true;
            // 
            // BtTimKiemMaPhong
            // 
            this.BtTimKiemMaPhong.Location = new System.Drawing.Point(256, 24);
            this.BtTimKiemMaPhong.Name = "BtTimKiemMaPhong";
            this.BtTimKiemMaPhong.Size = new System.Drawing.Size(144, 23);
            this.BtTimKiemMaPhong.TabIndex = 4;
            this.BtTimKiemMaPhong.Text = "Tìm kiếm theo mã phòng";
            this.BtTimKiemMaPhong.UseVisualStyleBackColor = true;
            this.BtTimKiemMaPhong.Click += new System.EventHandler(this.BtTimKiemMaPhong_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(98, 71);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(80, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // lBHoTen
            // 
            this.lBHoTen.AutoSize = true;
            this.lBHoTen.Location = new System.Drawing.Point(25, 74);
            this.lBHoTen.Name = "lBHoTen";
            this.lBHoTen.Size = new System.Drawing.Size(43, 13);
            this.lBHoTen.TabIndex = 1;
            this.lBHoTen.Text = "Họ Tên";
            // 
            // LbMaPhong
            // 
            this.LbMaPhong.AutoSize = true;
            this.LbMaPhong.Location = new System.Drawing.Point(25, 34);
            this.LbMaPhong.Name = "LbMaPhong";
            this.LbMaPhong.Size = new System.Drawing.Size(56, 13);
            this.LbMaPhong.TabIndex = 0;
            this.LbMaPhong.Text = "Mã Phòng";
            // 
            // gBThanhtoan
            // 
            this.gBThanhtoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gBThanhtoan.Controls.Add(this.BtTinhTien);
            this.gBThanhtoan.Controls.Add(this.bTthoat);
            this.gBThanhtoan.Controls.Add(this.lBphongKhachO);
            this.gBThanhtoan.Controls.Add(this.LBSoNgayKhachO);
            this.gBThanhtoan.Controls.Add(this.lBTongTienPhaiThanhToan);
            this.gBThanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBThanhtoan.Location = new System.Drawing.Point(12, 171);
            this.gBThanhtoan.Name = "gBThanhtoan";
            this.gBThanhtoan.Size = new System.Drawing.Size(437, 116);
            this.gBThanhtoan.TabIndex = 2;
            this.gBThanhtoan.TabStop = false;
            this.gBThanhtoan.Text = "Thanh Toán";
            // 
            // BtTinhTien
            // 
            this.BtTinhTien.Location = new System.Drawing.Point(325, 14);
            this.BtTinhTien.Name = "BtTinhTien";
            this.BtTinhTien.Size = new System.Drawing.Size(75, 23);
            this.BtTinhTien.TabIndex = 3;
            this.BtTinhTien.Text = "Tính Tiền";
            this.BtTinhTien.UseVisualStyleBackColor = true;
            // 
            // bTthoat
            // 
            this.bTthoat.Location = new System.Drawing.Point(325, 54);
            this.bTthoat.Name = "bTthoat";
            this.bTthoat.Size = new System.Drawing.Size(75, 23);
            this.bTthoat.TabIndex = 4;
            this.bTthoat.Text = "Thoát";
            this.bTthoat.UseVisualStyleBackColor = true;
            // 
            // lBphongKhachO
            // 
            this.lBphongKhachO.AutoSize = true;
            this.lBphongKhachO.Location = new System.Drawing.Point(72, 24);
            this.lBphongKhachO.Name = "lBphongKhachO";
            this.lBphongKhachO.Size = new System.Drawing.Size(83, 13);
            this.lBphongKhachO.TabIndex = 5;
            this.lBphongKhachO.Text = "Phòng Khách Ở";
            // 
            // LBSoNgayKhachO
            // 
            this.LBSoNgayKhachO.AutoSize = true;
            this.LBSoNgayKhachO.Location = new System.Drawing.Point(72, 59);
            this.LBSoNgayKhachO.Name = "LBSoNgayKhachO";
            this.LBSoNgayKhachO.Size = new System.Drawing.Size(93, 13);
            this.LBSoNgayKhachO.TabIndex = 6;
            this.LBSoNgayKhachO.Text = "Số Ngày Khách Ở";
            // 
            // lBTongTienPhaiThanhToan
            // 
            this.lBTongTienPhaiThanhToan.AutoSize = true;
            this.lBTongTienPhaiThanhToan.Location = new System.Drawing.Point(72, 89);
            this.lBTongTienPhaiThanhToan.Name = "lBTongTienPhaiThanhToan";
            this.lBTongTienPhaiThanhToan.Size = new System.Drawing.Size(129, 13);
            this.lBTongTienPhaiThanhToan.TabIndex = 7;
            this.lBTongTienPhaiThanhToan.Text = "Tổng tiền phải thanh toán";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // chiTietKHDataSet
            // 
            this.chiTietKHDataSet.DataSetName = "ChiTietKHDataSet";
            this.chiTietKHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource2
            // 
            this.tableBindingSource2.DataMember = "Table";
            this.tableBindingSource2.DataSource = this.chiTietKHDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Đồ_án.ChiTietKHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AutoGenerateColumns = false;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.tableDataGridView.DataSource = this.tableBindingSource2;
            this.tableDataGridView.Location = new System.Drawing.Point(18, 18);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.Size = new System.Drawing.Size(758, 129);
            this.tableDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Mã KH";
            this.dataGridViewTextBoxColumn6.HeaderText = "Mã KH";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Họ tên";
            this.dataGridViewTextBoxColumn7.HeaderText = "Họ tên";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 81;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CMT";
            this.dataGridViewTextBoxColumn8.HeaderText = "CMT";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 65;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Ngày Đến";
            this.dataGridViewTextBoxColumn9.HeaderText = "Ngày Đến";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 104;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Mã Phòng";
            this.dataGridViewTextBoxColumn10.HeaderText = "Mã Phòng";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 105;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Địa Chỉ";
            this.dataGridViewTextBoxColumn11.HeaderText = "Địa Chỉ";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // gBChiTietKHTT
            // 
            this.gBChiTietKHTT.AutoSize = true;
            this.gBChiTietKHTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gBChiTietKHTT.Controls.Add(this.tableDataGridView);
            this.gBChiTietKHTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBChiTietKHTT.Location = new System.Drawing.Point(12, 294);
            this.gBChiTietKHTT.Name = "gBChiTietKHTT";
            this.gBChiTietKHTT.Size = new System.Drawing.Size(790, 169);
            this.gBChiTietKHTT.TabIndex = 5;
            this.gBChiTietKHTT.TabStop = false;
            this.gBChiTietKHTT.Text = "Chi Tiết Khách Hàng Thanh Toán";
            this.gBChiTietKHTT.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Đồ_án.Properties.Resources.thiet_ke_logo_khach_san_dep;
            this.pictureBox1.Location = new System.Drawing.Point(455, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(817, 475);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gBChiTietKHTT);
            this.Controls.Add(this.gBThanhtoan);
            this.Controls.Add(this.GbTimKiem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GbTimKiem.ResumeLayout(false);
            this.GbTimKiem.PerformLayout();
            this.gBThanhtoan.ResumeLayout(false);
            this.gBThanhtoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietKHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.gBChiTietKHTT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbTimKiem;
        private System.Windows.Forms.GroupBox gBThanhtoan;
        private System.Windows.Forms.Button BtTimKiemTheoHoTen;
        private System.Windows.Forms.Button BtTimKiemMaPhong;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lBHoTen;
        private System.Windows.Forms.Label LbMaPhong;
        private System.Windows.Forms.Button BtTinhTien;
        private System.Windows.Forms.Button bTthoat;
        private System.Windows.Forms.Label lBphongKhachO;
        private System.Windows.Forms.Label LBSoNgayKhachO;
        private System.Windows.Forms.Label lBTongTienPhaiThanhToan;
       
        private System.Windows.Forms.BindingSource tableBindingSource;
       
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ImageList imageList1;
        private ChiTietKHDataSet chiTietKHDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource2;
        private ChiTietKHDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private ChiTietKHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.GroupBox gBChiTietKHTT;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

