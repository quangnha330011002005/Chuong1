using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace BT01
{
    public partial class Form1 : Form
    {
        //Khai báo các đối tượng

        DataSet ds = new DataSet();
        //
        DataTable tblKhoa = new DataTable("KHOA");
        DataTable tblSinhVien = new DataTable("SINHVIEN");
        DataTable tblKetQua = new DataTable("KETQUA");

        int stt = -1;

        public Form1()
        {
            InitializeComponent();
        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tạo_Cau_Truc_Cac_Bang();
            Moc_Noi_Quan_He_Cac_Bang();
            Nhap_Lieu_Cac_Bang();
            Khoi_Tao_Combo_Khoa();
            btnDau.PerformClick();
        }
        private Double TongDiem(String MSV)
        {
            double kq = 0;
            Object td = tblKetQua.Compute("sum(Diem)", "MaSV='" + MSV + "'");
            if (td == DBNull.Value)
            {
                kq = 0;
            }
            else kq = Convert.ToDouble(td);
            return kq;
        }

        public void Gandulieu(int sst)
        {
            DataRow rsv = tblSinhVien.Rows[stt];
            txtMaSv.Text = rsv["MaSV"].ToString();
            txtHoSv.Text = rsv["HoSV"].ToString();
            txtTenSv.Text = rsv["TenSV"].ToString();
            chkPhai.Checked = (Boolean)rsv["Phai"];
            dtpNgaySinh.Text = rsv["NgaySinh"].ToString();
            txtNoiSinh.Text = rsv["NoiSinh"].ToString();
            cboMaKhoa.SelectedValue = rsv["MaKH"].ToString();
            txtHocBong.Text = rsv["HocBong"].ToString();

            lblSTT.Text = (stt + 1) + "/" + tblSinhVien.Rows.Count;

            txtTongDiem.Text = TongDiem(txtMaSv.Text).ToString();
        }

        private void Khoi_Tao_Combo_Khoa()
        {
            cboMaKhoa.DisplayMember = "TenKH";
            cboMaKhoa.ValueMember = "MaKH";
            cboMaKhoa.DataSource = tblKhoa;
        }

        private void Nhap_Lieu_Cac_Bang()
        {
            Nhap_Lieu_tblKhoa();
            Nhap_Lieu_tblSinhVien();
            Nhap_Lieu_tblKetQua();
        }

        private void Nhap_Lieu_tblKetQua()
        {
            string[] Mang_kq = File.ReadAllLines(@"..\..\..\data\ketqua.txt");
            foreach (string chuoi_kq in Mang_kq)
            {
                //Tách chuỗi khoa thành các thành phần tương ứng với MaKh và TenKh
                string[] Mang_thanh_phan = chuoi_kq.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                DataRow rkq = tblKetQua.NewRow();
                //Gán giá trị cho các cột của dòng mới tạo ra
                for (int i = 0; i < Mang_thanh_phan.Length; i++)
                    rkq[i] = Mang_thanh_phan[i];

                //Thêm dòng vừa tạo vào tblKetqua
                tblKetQua.Rows.Add(rkq);
            }
        }

        private void Nhap_Lieu_tblSinhVien()
        {
            //Nhập liệu cho tblKhoa => Đọc dữ liệu từ tập tin SINHVIEN.txt
            string[] Mang_sv = File.ReadAllLines(@"..\..\..\data\sinhvien.txt");
            foreach (string Chuoi_sv in Mang_sv)
            {
                //Tách Chuoi_sv thành các thành phần tương ứng với các cột trong tblSinhVien
                string[] Mang_Thanh_Phan = Chuoi_sv.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                //Tạo một dòng mới có cấu trúc giống cấu trúc của một dòng trong tblSinhVien
                DataRow rsv = tblSinhVien.NewRow();
                //Gán giá trị cho các cột của dòng mới tạo ra
                for (int i = 0; i < Mang_Thanh_Phan.Length; i++)
                    rsv[i] = Mang_Thanh_Phan[i];

                //Thêm dòng vừa mới tạo vào tblSinhVien
                tblSinhVien.Rows.Add(rsv);
            }
        }

        private void Nhap_Lieu_tblKhoa()
        {
            //Nhập liệu cho tblKhoa => Đọc dữ liệu từ tập tin KhOA.txt
            string[] Mang_khoa = File.ReadAllLines(@"..\..\..\data\khoa.txt");
            foreach (string Chuoi_khoa in Mang_khoa)
            {
                //Tách Chuoi_Khoa thành các thành phần tương ứng với MaKH và TenKH
                string[] Mang_Thanh_Phan = Chuoi_khoa.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                //Tạo một dòng mới có cấu trúc giống cấu trúc của một dòng trong tblKhoa
                DataRow rkh = tblKhoa.NewRow();
                //Gán giá trị cho các cột của dòng mới tạo ra
                rkh[0] = Mang_Thanh_Phan[0];
                rkh[1] = Mang_Thanh_Phan[1];
                //Thêm dòng vừa tạo ra vào khoa
                tblKhoa.Rows.Add(rkh);
            }
        }

        private void Moc_Noi_Quan_He_Cac_Bang()
        {
            //Tạo quan hệ giữa tblKhoa và tblSinhVien
            ds.Relations.Add("FK_KH_SV", ds.Tables["KhOA"].Columns["MaKH"], ds.Tables["SINHVIEN"].Columns["MaKH"], true);
            ds.Relations.Add("FK_SV_KQ", ds.Tables["SINHVIEN"].Columns["MaSV"], ds.Tables["KETQUA"].Columns["MaSV"], true);

            ds.Relations["FK_KH_SV"].ChildKeyConstraint.DeleteRule = Rule.None;
            ds.Relations["FK_SV_KQ"].ChildKeyConstraint.DeleteRule = Rule.None;
        }

        private void Tạo_Cau_Truc_Cac_Bang()
        {
            //Tạo Cấu trúc cho Datatable tương ứng với bảng KHOA
            tblKhoa.Columns.Add("MaKH", typeof(string));
            tblKhoa.Columns.Add("TENKH", typeof(string));

            //Tạo Khoá Chính Cho tblKHOA
            tblKhoa.PrimaryKey = new DataColumn[] { tblKhoa.Columns["MAKH"] };

            //Tạo Cấu trúc cho Datatable tương ứng với bảng SINHVIEN
            tblSinhVien.Columns.Add("MaSV", typeof(string));
            tblSinhVien.Columns.Add("HoSV", typeof(string));
            tblSinhVien.Columns.Add("TenSV", typeof(string));
            tblSinhVien.Columns.Add("Phai", typeof(Boolean));
            tblSinhVien.Columns.Add("NgaySinh", typeof(DateTime));
            tblSinhVien.Columns.Add("NoiSinh", typeof(string));
            tblSinhVien.Columns.Add("MaKH", typeof(string));
            tblSinhVien.Columns.Add("HocBong", typeof(double));

            //Tạo Khoá Chính cho tblSinhVien
            tblSinhVien.PrimaryKey = new DataColumn[] { tblSinhVien.Columns["MaSV"] };


            // Tạo Cấu trúc cho Datatable tương ứng với bảng KETQUA

            tblKetQua.Columns.Add("MaSV", typeof(string));
            tblKetQua.Columns.Add("MaMH", typeof(string));
            tblKetQua.Columns.Add("Diem", typeof(double));

            //Tạo Khoá Chọm cjp tblKETQUA
            tblKetQua.PrimaryKey = new DataColumn[] { tblKetQua.Columns["MaSV"], tblKetQua.Columns["MaMH"] };

            //Thêm các DataTable vào DataSet,dùng từng lệnh ->Không dùng

            //ds.Tables.Add(tblKhoa);
            //ds.Tables.Add(tblSinhVien);
            //ds.Tables.Add(tblKetQua);

            //Thêm đồng thời nhiều Datatable vào DataSet
            ds.Tables.AddRange(new DataTable[] { tblKhoa, tblSinhVien, tblKetQua });
        }

        private void txtTongDiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (stt == 0) return;
            stt--;
            Gandulieu(stt);
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            stt = 0;
            Gandulieu(stt);
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (stt == tblSinhVien.Rows.Count - 1) return;
            stt++;
            Gandulieu(stt);
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            stt = tblSinhVien.Rows.Count - 1;
            Gandulieu(stt);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSv.ReadOnly = false;
            foreach (Control ctl in this.Controls)

                if (ctl is TextBox)
                    (ctl as TextBox).Clear();
                else if (ctl is CheckBox)
                    (ctl as CheckBox).Checked = true;
                else if (ctl is ComboBox)
                    (ctl as ComboBox).SelectedIndex = 0;
                else if (ctl is DateTimePicker)
                    (ctl as DateTimePicker).Value = new DateTime(2005, 10, 30);

            txtMaSv.Focus();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            txtMaSv.ReadOnly = true;
            Gandulieu(stt);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DataRow rsv = tblSinhVien.Rows.Find(txtMaSv.Text);

            DataRow[] Mang_dong_lien_quan = rsv.GetChildRows("FK_SV_KQ");
            if (Mang_dong_lien_quan.Length > 0)

                MessageBox.Show("**Không xóa được sinh vien vì đã có kết quả thi**");
            else
            {
                DialogResult tl;
                tl = MessageBox.Show("Bạn có muốn xóa sinh viên không", "Cẩn Thận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    rsv.Delete();
                    btnDau.PerformClick();
                }
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (txtMaSv.ReadOnly == true)
            {
                //Xác định dòng cần sửa
                DataRow rsv = tblSinhVien.Rows.Find(txtMaSv.Text);
                //Tiến hành sửa
               // rsv["MaSV"] = txtMaSv.Text;
                rsv["HoSV"] = txtHoSv.Text;
                rsv["TenSV"] = txtTenSv.Text;
                rsv["Phai"] = chkPhai.Checked;
                rsv["NgaySinh"] = dtpNgaySinh.Text;
                rsv["NoiSinh"] = txtNoiSinh.Text;
                rsv["MaKH"] = cboMaKhoa.SelectedValue.ToString();
                rsv["HocBong"] = txtHocBong.Text;
            }
            else//Ghi sau khi thêm
            {
                // Kiểm tra xem mã sinh viên có rỗng hay không
                if (string.IsNullOrEmpty(txtMaSv.Text))
                {
                    MessageBox.Show("Mã sinh viên không được để trống.");
                    txtMaSv.Focus();
                    return;
                }
                //Kiểm tra có bị trùng khóa chính
                DataRow rsv = tblSinhVien.Rows.Find(txtMaSv.Text);
                if (rsv!=null)
                {
                    MessageBox.Show("Đã bị trùng mã sv,mời nhập ma sv khac");
                    txtMaSv.Focus();
                    return;
                }
                //Tạo 1 dòng sinh viên mới
                rsv=tblSinhVien.NewRow();
                rsv["MaSV"] = txtMaSv.Text;
                rsv["HoSV"] = txtHoSv.Text;
                rsv["TenSV"] = txtTenSv.Text;
                rsv["Phai"] = chkPhai.Checked;
                rsv["NgaySinh"] = dtpNgaySinh.Text;
                rsv["NoiSinh"] = txtNoiSinh.Text;
                rsv["MaKH"] = cboMaKhoa.SelectedValue.ToString();
                rsv["HocBong"] = txtHocBong.Text;
                tblSinhVien.Rows.Add(rsv);
                txtMaSv.ReadOnly = true;    
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Ghi tập tin
            //Lưu ý: tblSinhVien.Rows => Tập hợp dòng (không phải là màng)
            //=> Chuyyển thành máng => ItemArray
            //=> Chuyển 1 mảng thành chuỗi => Join
            //=> Thuật toán ghi 1 Datatblea vào tập tin
            //1. Khai báo 1 mảng chuỗi với mỗi phần tử tương ứng với 1 dòng trong DataTable
            //2. Duyệt qua tập hợp Rows của Datalable và đưa từng dòng vào màng chuỗi với hàm Join
            // 3.Sử dụng phương thức WriteAllLines để ghi mảng chuỗi vào tập SINHVIEN.TXT
            List<string> Mang_Chuoi_Sinh_Vien = new List<string>();
            foreach (DataRow rsv in tblSinhVien.Rows)
            {
                //Biến màng thành chuỗi
                string Chuoi_Dong_sinh_Vien = string.Join("|", rsv.ItemArray);
                // Thêm chuỗi trên vào Mang_Chuoi_Sinh Vien
                Mang_Chuoi_Sinh_Vien.Add(Chuoi_Dong_sinh_Vien);
            }
            //Ghi Mang Chuoi Sinh Vien vào tập tin
            File.WriteAllLines(@"..\..\..\data\sinhvien.txt", Mang_Chuoi_Sinh_Vien);

        }
    }
}
