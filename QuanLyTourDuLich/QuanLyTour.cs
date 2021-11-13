﻿using System;
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
            Grid_Danhsachtour.DataSource = new TourBUS().List(Grid_Danhsachtour);
        }

        //Button thêm =========================================================================
        private void button1_Click(object sender, EventArgs e)
        {
            new QuanLyTour_Them().ShowDialog();
        }

        //Button Sửa ===========================================================================
        private void button2_Click(object sender, EventArgs e)
        {
            int selectedrowindex = Grid_Danhsachtour.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Grid_Danhsachtour.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id_Tour"].Value);
            new QuanLyTour_Sua(cellValue).ShowDialog();
        }
        //Button Chi tiết =======================================================================
        private void button4_Click(object sender, EventArgs e)
        {
            int selectedrowindex = Grid_Danhsachtour.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Grid_Danhsachtour.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id_Tour"].Value);
            QuanLyChiTietTour ql_ctt = new QuanLyChiTietTour(cellValue);
            ql_ctt.ShowDialog();
        }

        //Button Reload ==========================================================================
        private void button5_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        //Button trang QL Nhân viên ============================================================
        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedrowindex = Grid_Danhsachtour.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Grid_Danhsachtour.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id_Tour"].Value);
            if (new TourBUS().Delete(cellValue)) {
                MessageBox.Show("Xóa thành công");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            new TourBUS().ListSearch(Grid_Danhsachtour,textBox1);
        }

        private void Grid_Danhsachtour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
