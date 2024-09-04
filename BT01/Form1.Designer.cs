
namespace BT01
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaSv = new System.Windows.Forms.TextBox();
            this.txtTenSv = new System.Windows.Forms.TextBox();
            this.txtHoSv = new System.Windows.Forms.TextBox();
            this.txtTongDiem = new System.Windows.Forms.TextBox();
            this.txtHocBong = new System.Windows.Forms.TextBox();
            this.cboMaKhoa = new System.Windows.Forms.ComboBox();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnDau = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.btnKhong = new System.Windows.Forms.Button();
            this.lblSTT = new System.Windows.Forms.Label();
            this.chkPhai = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(37, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên SV";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(37, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(37, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nơi Sinh";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(37, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Khoa";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(37, 312);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tổng điểm";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(37, 270);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Học Bổng";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtMaSv
            // 
            this.txtMaSv.Location = new System.Drawing.Point(145, 32);
            this.txtMaSv.Name = "txtMaSv";
            this.txtMaSv.Size = new System.Drawing.Size(289, 32);
            this.txtMaSv.TabIndex = 1;
            // 
            // txtTenSv
            // 
            this.txtTenSv.Location = new System.Drawing.Point(345, 65);
            this.txtTenSv.Name = "txtTenSv";
            this.txtTenSv.Size = new System.Drawing.Size(89, 32);
            this.txtTenSv.TabIndex = 4;
            // 
            // txtHoSv
            // 
            this.txtHoSv.Location = new System.Drawing.Point(145, 65);
            this.txtHoSv.Name = "txtHoSv";
            this.txtHoSv.Size = new System.Drawing.Size(194, 32);
            this.txtHoSv.TabIndex = 3;
            // 
            // txtTongDiem
            // 
            this.txtTongDiem.Location = new System.Drawing.Point(144, 309);
            this.txtTongDiem.Name = "txtTongDiem";
            this.txtTongDiem.Size = new System.Drawing.Size(290, 32);
            this.txtTongDiem.TabIndex = 15;
            this.txtTongDiem.TextChanged += new System.EventHandler(this.txtTongDiem_TextChanged);
            // 
            // txtHocBong
            // 
            this.txtHocBong.Location = new System.Drawing.Point(145, 267);
            this.txtHocBong.Name = "txtHocBong";
            this.txtHocBong.Size = new System.Drawing.Size(289, 32);
            this.txtHocBong.TabIndex = 13;
            // 
            // cboMaKhoa
            // 
            this.cboMaKhoa.FormattingEnabled = true;
            this.cboMaKhoa.Location = new System.Drawing.Point(145, 225);
            this.cboMaKhoa.Name = "cboMaKhoa";
            this.cboMaKhoa.Size = new System.Drawing.Size(289, 32);
            this.cboMaKhoa.TabIndex = 11;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(145, 179);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(290, 32);
            this.txtNoiSinh.TabIndex = 9;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/mm/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(145, 138);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(289, 32);
            this.dtpNgaySinh.TabIndex = 7;
            // 
            // btnDau
            // 
            this.btnDau.ForeColor = System.Drawing.Color.Firebrick;
            this.btnDau.Location = new System.Drawing.Point(41, 359);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(80, 30);
            this.btnDau.TabIndex = 16;
            this.btnDau.TabStop = false;
            this.btnDau.Text = "Đầu";
            this.btnDau.UseVisualStyleBackColor = true;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThem.Location = new System.Drawing.Point(45, 395);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 31);
            this.btnThem.TabIndex = 21;
            this.btnThem.TabStop = false;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTruoc.Location = new System.Drawing.Point(127, 359);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(80, 30);
            this.btnTruoc.TabIndex = 17;
            this.btnTruoc.TabStop = false;
            this.btnTruoc.Text = "Trước";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHuy.Location = new System.Drawing.Point(148, 395);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(80, 30);
            this.btnHuy.TabIndex = 22;
            this.btnHuy.TabStop = false;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSau
            // 
            this.btnSau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSau.Location = new System.Drawing.Point(276, 359);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(80, 30);
            this.btnSau.TabIndex = 19;
            this.btnSau.TabStop = false;
            this.btnSau.Text = "Sau";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGhi.Location = new System.Drawing.Point(240, 395);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(80, 30);
            this.btnGhi.TabIndex = 23;
            this.btnGhi.TabStop = false;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnCuoi
            // 
            this.btnCuoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCuoi.Location = new System.Drawing.Point(362, 359);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(80, 30);
            this.btnCuoi.TabIndex = 20;
            this.btnCuoi.TabStop = false;
            this.btnCuoi.Text = "Cuối";
            this.btnCuoi.UseVisualStyleBackColor = true;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // btnKhong
            // 
            this.btnKhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKhong.Location = new System.Drawing.Point(339, 395);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(99, 30);
            this.btnKhong.TabIndex = 24;
            this.btnKhong.TabStop = false;
            this.btnKhong.Text = "Không";
            this.btnKhong.UseVisualStyleBackColor = true;
            this.btnKhong.Click += new System.EventHandler(this.btnKhong_Click);
            // 
            // lblSTT
            // 
            this.lblSTT.AutoSize = true;
            this.lblSTT.Location = new System.Drawing.Point(219, 365);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(64, 24);
            this.lblSTT.TabIndex = 18;
            this.lblSTT.Text = "label8";
            // 
            // chkPhai
            // 
            this.chkPhai.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPhai.Checked = true;
            this.chkPhai.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPhai.Location = new System.Drawing.Point(36, 100);
            this.chkPhai.Name = "chkPhai";
            this.chkPhai.Size = new System.Drawing.Size(129, 32);
            this.chkPhai.TabIndex = 5;
            this.chkPhai.Text = "Phái";
            this.chkPhai.UseVisualStyleBackColor = true;
            this.chkPhai.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 470);
            this.Controls.Add(this.lblSTT);
            this.Controls.Add(this.btnKhong);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnCuoi);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnDau);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.cboMaKhoa);
            this.Controls.Add(this.txtHoSv);
            this.Controls.Add(this.txtTenSv);
            this.Controls.Add(this.txtNoiSinh);
            this.Controls.Add(this.txtHocBong);
            this.Controls.Add(this.txtTongDiem);
            this.Controls.Add(this.txtMaSv);
            this.Controls.Add(this.chkPhai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "BT01-Quản lý sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaSv;
        private System.Windows.Forms.TextBox txtTenSv;
        private System.Windows.Forms.TextBox txtHoSv;
        private System.Windows.Forms.TextBox txtTongDiem;
        private System.Windows.Forms.TextBox txtHocBong;
        private System.Windows.Forms.ComboBox cboMaKhoa;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnCuoi;
        private System.Windows.Forms.Button btnKhong;
        private System.Windows.Forms.Label lblSTT;
        private System.Windows.Forms.CheckBox chkPhai;
    }
}

