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
        public QuanLyChiTietTour()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            QuanLyTour TOUR = new QuanLyTour();
            TOUR.Show();
        }
    }
}
