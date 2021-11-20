using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QuanLyTourDuLich
{
    public partial class QuanLyDoan : Form
    {
        public QuanLyDoan()
        {
            InitializeComponent();
            BindGrid();
        }
        public void BindGrid()
        {
            Grid_Danhsachdoan.DataSource = new DoanDuLichBUS().List();
        }
        //Button thêm 
        private void button1_Click(object sender, EventArgs e)
        {
            new QuanLyDoan_Them().ShowDialog();
            BindGrid();
        }

        //Button Sửa 
        private void button2_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachdoan.RowCount != 0)
            {
                int selectedrowindex = Grid_Danhsachdoan.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachdoan.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_Doan"].Value);
                new QuanLyDoan_Sua(cellValue).ShowDialog();
                BindGrid();
            }
        }

        //Button Xóa 
        private void button3_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachdoan.RowCount != 0)
            {
                int selectedrowindex = Grid_Danhsachdoan.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachdoan.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_Doan"].Value);
                if (new DoanDuLichBUS().Delete(cellValue))
                {
                    MessageBox.Show("Xóa thành công");
                    BindGrid();
                }
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
            Grid_Danhsachdoan.DataSource = new DoanDuLichBUS().ListSearch(search);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachdoan.RowCount != 0)
            {
                int selectedrowindex = Grid_Danhsachdoan.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachdoan.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_Doan"].Value);
                QuanLyChiTietDoan ql_ctt = new QuanLyChiTietDoan(cellValue);
                ql_ctt.ShowDialog();
            }
        }
    }
}
