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
    public partial class QuanLyChiTietDoan_Them : Form
    {
        public QuanLyChiTietDoan_Them()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string makhach = "KH0001";
            string madoan = "DOAN01032021";

            /*string matour = txtMaNV.Text;
            string madiadiem = txtHoTenNV.Text;*/

            if (new ChiTietDoanBUS().Insert(new ChiTietDoanDTO(madoan, makhach)))
            {
                MessageBox.Show("Thêm thành công");
                Hide();
            }
        }
    }
}
