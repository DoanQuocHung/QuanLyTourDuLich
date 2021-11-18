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
    public partial class QuanLyKhachHang_Them : Form
    {
        public QuanLyKhachHang_Them()
        {
            InitializeComponent();
            txt_1.Text = new KhachHangBUS().MakeID();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKH = txt_1.Text;
            string hoten = txt_2.Text;
            string cmnd = txt_3.Text;
            string diachi = txt_4.Text;
            string gioiTinh = txt_5.Text;
            string sdt = txt_6.Text;
            string quoctich = txt_7.Text;
            
            if (new KhachHangBUS().Insert(new KhachDTO(maKH, hoten, cmnd, diachi, gioiTinh, sdt, quoctich, 1)))
            {
                MessageBox.Show("Thêm thành công");
                Hide();
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txt_1.Text = "";
            txt_2.Text = "";
            txt_3.Text = "";
            txt_4.Text = "";
            txt_5.Text = "";
            txt_6.Text = "";
            txt_7.Text = "";
            txt_8.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
