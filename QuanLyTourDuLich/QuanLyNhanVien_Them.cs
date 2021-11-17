using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyTourDuLich
{
    public partial class QuanLyNhanVien_Them : Form
    {
        public QuanLyNhanVien_Them()
        {
            InitializeComponent();

            txtMaNV.Text = new NhanVienBUS().MakeID();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string hotenNV = txtHoTenNV.Text;
            string email = txtEmail.Text;
            string sdt = txtSDT.Text;
            string gioiTinh = txtGioiTinh.Text;
            if (new NhanVienBUS().Insert(new NhanVienDTO(maNV, hotenNV, email, sdt, gioiTinh, 1)))
            {
                MessageBox.Show("Thêm thành công");
                Hide();
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtHoTenNV.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtGioiTinh.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
