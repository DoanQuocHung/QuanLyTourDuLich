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
    public partial class QuanLyDoan_Them : Form
    {
        public QuanLyDoan_Them()
        {
            InitializeComponent();
            textBox1.Text = new DoanDuLichBUS().MakeID();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string madoan = txtMaNV.Text;
            string tendoan = txtHoTenNV.Text;
            string matour = txtEmail.Text;
            string ngaykhoihanh = txtSDT.Text;
            string ngayketthuc = txtGioiTinh.Text;
            long doanhthu = Convert.ToInt32(textBox2.Text);
            string noidung = textBox1.Text;
            if (new DoanDuLichBUS().Insert(new DoanDuLichDTO(madoan,tendoan,matour,ngaykhoihanh,ngayketthuc,doanhthu,noidung)))
            {
                MessageBox.Show("Thêm thành công");

                Hide();
            }
        }
    }
}
