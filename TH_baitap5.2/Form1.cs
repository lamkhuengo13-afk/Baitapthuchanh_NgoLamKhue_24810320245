using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TH_baitap5._2 
{

    public class ServiceItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Price:N0} VNĐ";
        }
    }

    public partial class Form1 : Form
    {
        private List<ServiceItem> allServices = new List<ServiceItem>();

        public Form1()
        {
            InitializeComponent();

            this.Load += new EventHandler(Form1_Load);
            cboCategory.SelectedIndexChanged += new EventHandler(cboCategory_SelectedIndexChanged);

            btnSelect.Click += new EventHandler(btnSelect_Click);
            lstAvailableServices.DoubleClick += new EventHandler(btnSelect_Click); // Double click cũng gọi hàm chọn

            btnRemove.Click += new EventHandler(btnRemove_Click);
            btnClearAll.Click += new EventHandler(btnClearAll_Click);

            txtChietKhau.TextChanged += new EventHandler(txtChietKhau_TextChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TaoDuLieuMau();

            cboCategory.Items.AddRange(new string[] { "Khám bệnh", "Xét nghiệm", "Chụp X-Quang", "Vắc-xin" });
            cboCategory.SelectedIndex = 0; // Tự động chọn dòng đầu tiên
        }

        private void TaoDuLieuMau()
        {
            allServices.Add(new ServiceItem { Name = "Khám tổng quát", Price = 200000, Category = "Khám bệnh" });
            allServices.Add(new ServiceItem { Name = "Khám chuyên khoa", Price = 350000, Category = "Khám bệnh" });

            allServices.Add(new ServiceItem { Name = "Xét nghiệm máu", Price = 150000, Category = "Xét nghiệm" });
            allServices.Add(new ServiceItem { Name = "Xét nghiệm nước tiểu", Price = 100000, Category = "Xét nghiệm" });

            allServices.Add(new ServiceItem { Name = "Chụp X-Quang Phổi", Price = 250000, Category = "Chụp X-Quang" });
            allServices.Add(new ServiceItem { Name = "Siêu âm ổ bụng", Price = 300000, Category = "Chụp X-Quang" });

            allServices.Add(new ServiceItem { Name = "Vắc-xin Cúm mùa", Price = 350000, Category = "Vắc-xin" });
            allServices.Add(new ServiceItem { Name = "Vắc-xin Viêm gan B", Price = 450000, Category = "Vắc-xin" });
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAvailableServices.Items.Clear();
            string selectedCategory = cboCategory.SelectedItem.ToString();

            var filteredServices = allServices.Where(s => s.Category == selectedCategory).ToList();

            foreach (var item in filteredServices)
            {
                lstAvailableServices.Items.Add(item);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstAvailableServices.SelectedItem != null)
            {
                lstSelectedServices.Items.Add(lstAvailableServices.SelectedItem);
                TinhTien(); 
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelectedServices.SelectedItem != null)
            {
                lstSelectedServices.Items.Remove(lstSelectedServices.SelectedItem);
                TinhTien(); 
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstSelectedServices.Items.Clear();
            TinhTien();
        }

        private void txtChietKhau_TextChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void TinhTien()
        {
            decimal tongTien = 0;

            foreach (ServiceItem item in lstSelectedServices.Items)
            {
                tongTien += item.Price;
            }

            decimal chietKhau = 0;
            if (decimal.TryParse(txtChietKhau.Text, out decimal parsedDiscount))
            {
                chietKhau = parsedDiscount;
            }

            decimal soTienGiam = tongTien * (chietKhau / 100);
            decimal thanhTien = tongTien - soTienGiam;

            txtTongTien.Text = tongTien.ToString("N0") + " VNĐ";
            txtThanhTien.Text = thanhTien.ToString("N0") + " VNĐ";
        }
    }
}