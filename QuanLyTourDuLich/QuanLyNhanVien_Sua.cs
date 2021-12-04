using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyTourDuLich
{
    public partial class QuanLyNhanVien_Sua : Form
    {
        public QuanLyNhanVien_Sua(String id)
        {
            InitializeComponent();
            NhanVienDTO edit = new NhanVienDTO();
            edit = new NhanVienBUS().ListSearch(id)[0];
            txtMaNV.Text = id;
            txtHoTenNV.Text = edit.Hoten_NV;
            txtEmail.Text = edit.Email_NV;
            txtSDT.Text = edit.Sdt_NV;
            if (edit.Gioitinh_NV.Equals("Nam"))
            {
                Nam.Checked = true;
            }
            else
            {
                Nu.Checked = true;
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
           /* string maNV = txtMaNV.Text;
            string hotenNV = txtHoTenNV.Text;
            string email = txtEmail.Text;
            string sdt = txtSDT.Text;
            string gioiTinh = txtGioiTinh.Text;
            int tinhTrang = 1;
            if (new NhanVienBUS().Update(new NhanVienDTO(maNV, hotenNV, email, sdt, gioiTinh, tinhTrang)))
            {
                MessageBox.Show("Sửa thành công");
                Hide();
            }*/
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
