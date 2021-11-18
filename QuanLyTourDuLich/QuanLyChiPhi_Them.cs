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
    public partial class QuanLyChiPhi_Them : Form
    {
        public QuanLyChiPhi_Them()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string maloai = "CP001";
            string madoan = "DOAN01032021";
            int thutu = 10000;*/
            string maloai = txtMaNV.Text;
            string madoan = txtHoTenNV.Text;
            int thutu = Int32.Parse(txtEmail.Text);

            if (new ChiPhiBUS().Insert(new ChiPhiDTO(maloai, madoan, thutu)))
            {
                MessageBox.Show("Thêm thành công");
                Hide();
            }
        }
    }
}
