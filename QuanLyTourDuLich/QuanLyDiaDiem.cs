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
    public partial class QuanLyDiaDiem : Form
    {
        public QuanLyDiaDiem()
        {
            InitializeComponent();
            BindGrid();
        }

        //QUẢN LÝ ĐỊA ĐIỂM =================================================================================================================
        //Hàm lấy danh sách
        public void BindGrid()
        {
            Grid_Danhsachdiadiem.DataSource = new DiaDiemBUS().List();
        }

        //Button thêm 
        private void button1_Click(object sender, EventArgs e)
        {
            new QuanLyDiaDiem_Them().ShowDialog();
            BindGrid();
        }

        //Button Sửa 
        private void button2_Click(object sender, EventArgs e)
        {
            int selectedrowindex = Grid_Danhsachdiadiem.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Grid_Danhsachdiadiem.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id_DiaDiem"].Value);
            new QuanLyDiaDiem_Sua(cellValue).ShowDialog();
            BindGrid();
        }

        //Button Xóa 
        private void button3_Click(object sender, EventArgs e)
        {
            int selectedrowindex = Grid_Danhsachdiadiem.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Grid_Danhsachdiadiem.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id_DiaDiem"].Value);
            if (new DiaDiemBUS().Delete(cellValue))
            {
                MessageBox.Show("Xóa thành công");
                BindGrid();
            }
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
            Grid_Danhsachdiadiem.DataSource = new TourBUS().ListSearch(search);
        }
    }
}
