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
    public partial class QuanLyKhachHang_Sua : Form
    {
        public QuanLyKhachHang_Sua(String id)
        {
            InitializeComponent();
            KhachDTO edit = new KhachDTO();
            edit = new KhachHangBUS().ListSearch(id)[0];
            txt_1.Text = id;
            txt_2.Text = edit.Hoten_Khach;
            txt_3.Text = edit.Cmnd_Khach;
            txt_4.Text = edit.Diachi_Khach;
            txt_5.Text = edit.Gioitinh_Khach;
            txt_6.Text = edit.Sdt_Khach;
            txt_7.Text = edit.Quoctich;
            txt_8.Text = edit.Tinh_Trang.ToString();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKH = txt_1.Text;
            string hoten = txt_2.Text;
            string cmnd = txt_3.Text;
            string diachi = txt_4.Text;
            string gioiTinh = txt_5.Text;
            string sdt = txt_6.Text;
            string quoctich = txt_7.Text;
            if (new KhachHangBUS().Update(new KhachDTO(maKH, hoten, cmnd, diachi, gioiTinh, sdt, quoctich, 1)))
            {
                MessageBox.Show("Sửa thành công");
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
    }
}
