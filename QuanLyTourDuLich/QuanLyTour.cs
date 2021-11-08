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
            new TourBUS().List(Grid_Danhsachtour);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new QuanLyTour_Them().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedrowindex = Grid_Danhsachtour.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Grid_Danhsachtour.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id_Tour"].Value);
            new QuanLyTour_Sua(cellValue).ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
