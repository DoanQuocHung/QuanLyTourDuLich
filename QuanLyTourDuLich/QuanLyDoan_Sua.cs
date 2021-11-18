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
    public partial class QuanLyDoan_Sua : Form
    {
        public QuanLyDoan_Sua(string id)
        {
            InitializeComponent();
            DoanDuLichDTO edit = new DoanDuLichDTO();
            edit = new DoanDuLichBUS().ListSearch(id)[0];
            txtMaNV.Text = id;
            txtHoTenNV.Text = edit.Id_Doan;
            txtEmail.Text = edit.Ten_Doan;
            txtSDT.Text = edit.Ngaykhoihanh;
            txtGioiTinh.Text = edit.Ngayketthuc;
            textBox2.Text = edit.Doanhthu.ToString();
            textBox1.Text = edit.Noidung;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            if (new DoanDuLichBUS().Update(new DoanDuLichDTO(madoan, tendoan, matour, ngaykhoihanh, ngayketthuc, doanhthu, noidung)))
            {
                MessageBox.Show("Sửa thành công");

                Hide();
            }
        }
    }
}
