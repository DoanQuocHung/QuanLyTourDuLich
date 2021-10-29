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
    public partial class QuanLyTour : Form
    {
        private TourBUS bus;
        public QuanLyTour()
        {
            InitializeComponent();
            bus = new TourBUS();
            BindGrid();
        }

        public void BindGrid()
        {
            bus.List(Grid_Danhsachtour);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            QuanLyChiTietTour chitiet = new QuanLyChiTietTour();
            chitiet.Show();
        }
    }
}
