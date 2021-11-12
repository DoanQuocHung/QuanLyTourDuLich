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
            //test
        }
        private void button14_icon()
        {
            button14.Image = Image.FromFile("img\\nv.jpg");
            button14.ImageAlign = ContentAlignment.MiddleRight;
            button14.TextAlign = ContentAlignment.MiddleLeft;
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
    }
}
