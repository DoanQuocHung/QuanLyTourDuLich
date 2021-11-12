using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyTourDuLich
{
    public partial class QuanLyChiTietTour : Form
    {
        public QuanLyChiTietTour(String id)
        {
            InitializeComponent();
            BindGrid();
        }

        public void BindGrid()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyChiTietTour_Them ql_ctt_them = new QuanLyChiTietTour_Them();
            ql_ctt_them.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            QuanLyChiTietTour_Sua ql_ctt_sua = new QuanLyChiTietTour_Sua();
            ql_ctt_sua.ShowDialog();
        }

    }
}
