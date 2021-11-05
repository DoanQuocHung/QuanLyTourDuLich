using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DAL;

namespace QuanLyTourDuLich
{
    public partial class QuanLyTour : Form
    {
        public QuanLyTour()
        {
            InitializeComponent();
            BindGrid();
        }

        public void BindGrid()
        {
            //thay doi nè
            TourBUS bus = new TourBUS();
            bus.List(Grid_Danhsachtour);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Button \"Thêm\" is coming soon (^.-) !");
            QuanLyTour_Them ql_ctt_them = new QuanLyTour_Them();
            ql_ctt_them.ShowDialog();
        }
        public void Sua(DataGridView data)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int tourid = Convert.ToInt32(Grid_Danhsachtour.Rows[e.RowIndex].Cells[0].Value);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
