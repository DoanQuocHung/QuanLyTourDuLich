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
    public partial class QuanLyPhanCong_Them : Form
    {
        public QuanLyPhanCong_Them()
        {
            InitializeComponent();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txt_1.Text;
            string hotenNV = txt_2.Text;
            string email = txt_3.Text;
            if (new NhanVienBUS().Insert(new PhanCongDTO(maNV, hotenNV, email)))
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
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
