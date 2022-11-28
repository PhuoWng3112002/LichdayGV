
namespace LichdayGV
{
    partial class FormLDGV
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
            this.label1 = new System.Windows.Forms.Label();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tbGhichu = new System.Windows.Forms.TextBox();
            this.cbTrangthai = new System.Windows.Forms.ComboBox();
            this.cbMaP = new System.Windows.Forms.ComboBox();
            this.cbMalop = new System.Windows.Forms.ComboBox();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.cbGV = new System.Windows.Forms.ComboBox();
            this.cbCaday = new System.Windows.Forms.ComboBox();
            this.tbNgayday = new System.Windows.Forms.MaskedTextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_LDGV = new System.Windows.Forms.DataGridView();
            this.ngayday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tengv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giảngViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânCôngLịchDạyGiảngViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.group1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LDGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHÂN CÔNG LỊCH DẠY GIẢNG VIÊN";
            // 
            // group1
            // 
            this.group1.Controls.Add(this.btnThoat);
            this.group1.Controls.Add(this.tbGhichu);
            this.group1.Controls.Add(this.cbTrangthai);
            this.group1.Controls.Add(this.cbMaP);
            this.group1.Controls.Add(this.cbMalop);
            this.group1.Controls.Add(this.cbMon);
            this.group1.Controls.Add(this.cbGV);
            this.group1.Controls.Add(this.cbCaday);
            this.group1.Controls.Add(this.tbNgayday);
            this.group1.Controls.Add(this.btnSua);
            this.group1.Controls.Add(this.btnXoa);
            this.group1.Controls.Add(this.btnBoqua);
            this.group1.Controls.Add(this.btnTimkiem);
            this.group1.Controls.Add(this.btnThem);
            this.group1.Controls.Add(this.label10);
            this.group1.Controls.Add(this.label9);
            this.group1.Controls.Add(this.label8);
            this.group1.Controls.Add(this.label7);
            this.group1.Controls.Add(this.label6);
            this.group1.Controls.Add(this.label5);
            this.group1.Controls.Add(this.label3);
            this.group1.Controls.Add(this.label2);
            this.group1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group1.Location = new System.Drawing.Point(17, 142);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(1237, 318);
            this.group1.TabIndex = 1;
            this.group1.TabStop = false;
            this.group1.Text = "I. Thông tin giảng viên";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThoat.Location = new System.Drawing.Point(1046, 252);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 35);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // tbGhichu
            // 
            this.tbGhichu.Location = new System.Drawing.Point(902, 119);
            this.tbGhichu.Multiline = true;
            this.tbGhichu.Name = "tbGhichu";
            this.tbGhichu.Size = new System.Drawing.Size(300, 81);
            this.tbGhichu.TabIndex = 21;
            // 
            // cbTrangthai
            // 
            this.cbTrangthai.FormattingEnabled = true;
            this.cbTrangthai.Location = new System.Drawing.Point(902, 54);
            this.cbTrangthai.Name = "cbTrangthai";
            this.cbTrangthai.Size = new System.Drawing.Size(300, 26);
            this.cbTrangthai.TabIndex = 20;
            // 
            // cbMaP
            // 
            this.cbMaP.FormattingEnabled = true;
            this.cbMaP.Location = new System.Drawing.Point(499, 180);
            this.cbMaP.Name = "cbMaP";
            this.cbMaP.Size = new System.Drawing.Size(262, 26);
            this.cbMaP.TabIndex = 19;
            // 
            // cbMalop
            // 
            this.cbMalop.FormattingEnabled = true;
            this.cbMalop.Location = new System.Drawing.Point(499, 120);
            this.cbMalop.Name = "cbMalop";
            this.cbMalop.Size = new System.Drawing.Size(262, 26);
            this.cbMalop.TabIndex = 18;
            // 
            // cbMon
            // 
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(499, 54);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(262, 26);
            this.cbMon.TabIndex = 17;
            // 
            // cbGV
            // 
            this.cbGV.FormattingEnabled = true;
            this.cbGV.Location = new System.Drawing.Point(109, 174);
            this.cbGV.Name = "cbGV";
            this.cbGV.Size = new System.Drawing.Size(218, 26);
            this.cbGV.TabIndex = 16;
            // 
            // cbCaday
            // 
            this.cbCaday.FormattingEnabled = true;
            this.cbCaday.Location = new System.Drawing.Point(109, 123);
            this.cbCaday.Name = "cbCaday";
            this.cbCaday.Size = new System.Drawing.Size(218, 26);
            this.cbCaday.TabIndex = 15;
            // 
            // tbNgayday
            // 
            this.tbNgayday.Location = new System.Drawing.Point(109, 61);
            this.tbNgayday.Mask = "00/00/0000";
            this.tbNgayday.Name = "tbNgayday";
            this.tbNgayday.Size = new System.Drawing.Size(218, 24);
            this.tbNgayday.TabIndex = 14;
            this.tbNgayday.ValidatingType = typeof(System.DateTime);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSua.Location = new System.Drawing.Point(245, 252);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 35);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoa.Location = new System.Drawing.Point(435, 252);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 35);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBoqua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBoqua.Location = new System.Drawing.Point(631, 252);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(94, 35);
            this.btnBoqua.TabIndex = 11;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = false;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimkiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimkiem.Location = new System.Drawing.Point(831, 252);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(98, 35);
            this.btnTimkiem.TabIndex = 10;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThem.Location = new System.Drawing.Point(66, 252);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 35);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(792, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Trạng thái";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Giảng viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Môn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mã lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(792, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ghi chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ca dạy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày dạy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_LDGV);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 492);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1237, 273);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "II. Danh sách lịch dạy";
            // 
            // dgv_LDGV
            // 
            this.dgv_LDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngayday,
            this.caday,
            this.tengv,
            this.tenmon,
            this.malop,
            this.maphong,
            this.trangthai,
            this.ghichu});
            this.dgv_LDGV.Location = new System.Drawing.Point(3, 37);
            this.dgv_LDGV.Name = "dgv_LDGV";
            this.dgv_LDGV.RowHeadersWidth = 51;
            this.dgv_LDGV.RowTemplate.Height = 24;
            this.dgv_LDGV.Size = new System.Drawing.Size(1231, 233);
            this.dgv_LDGV.TabIndex = 0;
            this.dgv_LDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LDGV_CellClick);
            // 
            // ngayday
            // 
            this.ngayday.DataPropertyName = "dNgayday";
            this.ngayday.HeaderText = "Ngày dạy";
            this.ngayday.MinimumWidth = 6;
            this.ngayday.Name = "ngayday";
            this.ngayday.Width = 125;
            // 
            // caday
            // 
            this.caday.DataPropertyName = "sCaday";
            this.caday.HeaderText = "Ca dạy";
            this.caday.MinimumWidth = 6;
            this.caday.Name = "caday";
            this.caday.Width = 125;
            // 
            // tengv
            // 
            this.tengv.DataPropertyName = "sTengv";
            this.tengv.HeaderText = "Tên giảng viên";
            this.tengv.MinimumWidth = 6;
            this.tengv.Name = "tengv";
            this.tengv.Width = 125;
            // 
            // tenmon
            // 
            this.tenmon.DataPropertyName = "sTenmon";
            this.tenmon.HeaderText = "Tên môn";
            this.tenmon.MinimumWidth = 6;
            this.tenmon.Name = "tenmon";
            this.tenmon.Width = 125;
            // 
            // malop
            // 
            this.malop.DataPropertyName = "sMalop";
            this.malop.HeaderText = "Mã lớp";
            this.malop.MinimumWidth = 6;
            this.malop.Name = "malop";
            this.malop.Width = 125;
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "sMap";
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.MinimumWidth = 6;
            this.maphong.Name = "maphong";
            this.maphong.Width = 125;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "sTrangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.Width = 125;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "sGhichu";
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.MinimumWidth = 6;
            this.ghichu.Name = "ghichu";
            this.ghichu.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.sToolStripMenuItem,
            this.phânCôngLịchDạyGiảngViênToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            this.trangChủToolStripMenuItem.Click += new System.EventHandler(this.trangChủToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mônHọcToolStripMenuItem,
            this.giảngViênToolStripMenuItem,
            this.lớpHọcToolStripMenuItem});
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.sToolStripMenuItem.Text = "Quản lý";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // mônHọcToolStripMenuItem
            // 
            this.mônHọcToolStripMenuItem.Name = "mônHọcToolStripMenuItem";
            this.mônHọcToolStripMenuItem.Size = new System.Drawing.Size(264, 30);
            this.mônHọcToolStripMenuItem.Text = "Quản lý môn học";
            this.mônHọcToolStripMenuItem.Click += new System.EventHandler(this.mônHọcToolStripMenuItem_Click);
            // 
            // giảngViênToolStripMenuItem
            // 
            this.giảngViênToolStripMenuItem.Name = "giảngViênToolStripMenuItem";
            this.giảngViênToolStripMenuItem.Size = new System.Drawing.Size(264, 30);
            this.giảngViênToolStripMenuItem.Text = "Quản lý giảng viên";
            this.giảngViênToolStripMenuItem.Click += new System.EventHandler(this.giảngViênToolStripMenuItem_Click);
            // 
            // lớpHọcToolStripMenuItem
            // 
            this.lớpHọcToolStripMenuItem.Name = "lớpHọcToolStripMenuItem";
            this.lớpHọcToolStripMenuItem.Size = new System.Drawing.Size(264, 30);
            this.lớpHọcToolStripMenuItem.Text = "Quản lý lớp học";
            this.lớpHọcToolStripMenuItem.Click += new System.EventHandler(this.lớpHọcToolStripMenuItem_Click);
            // 
            // phânCôngLịchDạyGiảngViênToolStripMenuItem
            // 
            this.phânCôngLịchDạyGiảngViênToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.phânCôngLịchDạyGiảngViênToolStripMenuItem.Name = "phânCôngLịchDạyGiảngViênToolStripMenuItem";
            this.phânCôngLịchDạyGiảngViênToolStripMenuItem.Size = new System.Drawing.Size(291, 29);
            this.phânCôngLịchDạyGiảngViênToolStripMenuItem.Text = "Phân công lịch dạy giảng viên";
            this.phânCôngLịchDạyGiảngViênToolStripMenuItem.Click += new System.EventHandler(this.phânCôngLịchDạyGiảngViênToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // FormLDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 809);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.group1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormLDGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLDGV";
            this.Load += new System.EventHandler(this.FormLDGV_Load);
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LDGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.TextBox tbGhichu;
        private System.Windows.Forms.ComboBox cbTrangthai;
        private System.Windows.Forms.ComboBox cbMaP;
        private System.Windows.Forms.ComboBox cbMalop;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.ComboBox cbGV;
        private System.Windows.Forms.ComboBox cbCaday;
        private System.Windows.Forms.MaskedTextBox tbNgayday;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_LDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayday;
        private System.Windows.Forms.DataGridViewTextBoxColumn caday;
        private System.Windows.Forms.DataGridViewTextBoxColumn tengv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giảngViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânCôngLịchDạyGiảngViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}