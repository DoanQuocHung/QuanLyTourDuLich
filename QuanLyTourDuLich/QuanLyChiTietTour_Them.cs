using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
namespace QuanLyTourDuLich
{
    public partial class QuanLyChiTietTour_Them : Form
    {
        public QuanLyChiTietTour_Them()
        {
            InitializeComponent();
        }

        private void QuanLyChiTietTour_Them_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matour = textBox1.Text;
            string madiadiem = textBox2.Text;
            int thutu = Int32.Parse(textBox3.Text);

            if (new ChiTietTourBUS().Insert(matour, madiadiem, thutu))
            {
                MessageBox.Show("Thêm thành công");
                Hide();
            }
        }
    }
}
