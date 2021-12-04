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
            Nam.Checked = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string hotenNV = HoTen_txt.Text;
            string email = Email_txt.Text;
            string sdt = SDT_txt.Text;
            string gioitinh = "";
            if (Nam.Checked)
                gioitinh = "Nam";
            else
                gioitinh = "Nữ";
            if(hotenNV.Equals(null)|email.Equals(null)|sdt.Equals(null))
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ");
                return;

            }
            if (new NhanVienBUS().Insert(new NhanVienDTO(maNV, hotenNV, email, sdt, gioitinh, 0)))
            {
                MessageBox.Show("Thêm thành công");
                Hide();
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
