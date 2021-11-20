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

        //QUẢN LÝ TOUR ====================================================================================================================
        //Hàm lấy danh sách
        public void BindGrid()
        {
            Grid_Danhsachtour.DataSource = new TourBUS().List();
        }

        //Button thêm 
        private void button1_Click(object sender, EventArgs e)
        {
            new QuanLyTour_Them().ShowDialog();
            BindGrid();
        }

        //Button Sửa 
        private void button2_Click(object sender, EventArgs e)
        {
            int selectedrowindex = Grid_Danhsachtour.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Grid_Danhsachtour.Rows[selectedrowindex];
            string cellValue =Convert.ToString(selectedRow.Cells["Id_Tour"].Value);
            new QuanLyTour_Sua(cellValue).ShowDialog();
            BindGrid();
        }

        //Button Xóa 
        private void button3_Click(object sender, EventArgs e)
        {
            int selectedrowindex = Grid_Danhsachtour.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Grid_Danhsachtour.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id_Tour"].Value);
            if (new TourBUS().Delete(cellValue))
            {
                MessageBox.Show("Xóa thành công");
                BindGrid();
            }
        }

        //Button Chi tiết 
        private void button4_Click(object sender, EventArgs e)
        {
            int selectedrowindex = Grid_Danhsachtour.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Grid_Danhsachtour.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id_Tour"].Value);
            QuanLyChiTietTour ql_ctt = new QuanLyChiTietTour(cellValue);
            ql_ctt.ShowDialog();
        }

        //Button Reload 
        private void button5_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        //Button tìm kiếm
        private void button6_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text;
            Grid_Danhsachtour.DataSource = new TourBUS().ListSearch(search);
        }
    }
}
