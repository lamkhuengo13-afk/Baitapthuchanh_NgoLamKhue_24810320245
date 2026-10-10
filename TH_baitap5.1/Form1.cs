using System;
using System.Windows.Forms;

namespace TH_baitap5._1 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnDangKy.Click += new EventHandler(btnDangKy_Click);
            btnLamMoi.Click += new EventHandler(btnLamMoi_Click);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            epCheck.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                epCheck.SetError(txtTenDangNhap, "Tên đăng nhập không được để trống!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                epCheck.SetError(txtMatKhau, "Mật khẩu không được để trống!");
                isValid = false;
            }

            if (txtMatKhau.Text != txtXacNhan.Text)
            {
                epCheck.SetError(txtXacNhan, "Mật khẩu nhập lại không khớp!");
                isValid = false;
            }

            DateTime ngaySinh = dtpNgaySinh.Value;
            int tuoi = DateTime.Now.Year - ngaySinh.Year;
            if (DateTime.Now.Date < ngaySinh.AddYears(tuoi))
            {
                tuoi--;
            }

            if (tuoi < 18)
            {
                epCheck.SetError(dtpNgaySinh, "Bạn phải đủ 18 tuổi trở lên!");
                isValid = false;
            }

            if (!chkDieuKhoan.Checked)
            {
                epCheck.SetError(chkDieuKhoan, "Bạn phải đồng ý với điều khoản dịch vụ!");
                isValid = false;
            }

            if (isValid)
            {
                string gioiTinh = radNam.Checked ? "Nam" : (radNam.Checked ? "Nữ" : "Chưa xác định");

                string message = $"Đăng ký thành công!\n\n" +
                                 $"- Tên đăng nhập: {txtTenDangNhap.Text}\n" +
                                 $"- Giới tính: {gioiTinh}\n" +
                                 $"- Ngày sinh: {ngaySinh.ToString("dd/MM/yyyy")} ({tuoi} tuổi)";

                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoiForm(); 
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        private void LamMoiForm()
        {
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtXacNhan.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            radNam.Checked = true; 
            chkDieuKhoan.Checked = false;
            epCheck.Clear(); 
            txtTenDangNhap.Focus();
        }
    }
}