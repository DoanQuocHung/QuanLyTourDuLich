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
            //BindGrid();
            DataProvider provider = new DataProvider();
            string query = "select * from TOUR";
            Grid_Danhsachtour.DataSource = provider.ExecuteQuery(query);
        }

        public void BindGrid()
        {
            TourBUS bus = new TourBUS();
            bus.List(Grid_Danhsachtour);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world !!");
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
