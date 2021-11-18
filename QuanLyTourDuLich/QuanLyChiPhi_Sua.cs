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
    public partial class QuanLyChiPhi_Sua : Form
    {
        public QuanLyChiPhi_Sua(string loai, string doan)
        {
            InitializeComponent();
            ChiPhiDTO edit = new ChiPhiDTO();
            edit = new ChiPhiBUS().get(loai, doan);

            txtMaNV.Text = edit.Id_LoaiChiPhi;
            txtHoTenNV.Text = edit.Id_Doan;
            txtEmail.Text = Convert.ToString(edit.Gia);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maloai = txtMaNV.Text;
            string madoan = txtHoTenNV.Text;
            int gia = Int32.Parse(txtEmail.Text);

            if (new ChiPhiBUS().Update(new ChiPhiDTO(maloai, madoan, gia),madoan))
            {
                MessageBox.Show("Sửa thành công");
                Hide();
            }
        }
    }
}
