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
    public partial class QuanLyPhanCong : Form
    {
        public QuanLyPhanCong()
        {
            InitializeComponent();
            BindGrid();
        }

        public void BindGrid()
        {
            Grid_Danhsachphancong.DataSource = new PhanCongBUS().List();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new QuanLyPhanCong_Them().ShowDialog();
            BindGrid();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int selectedrowindex = Grid_Danhsachphancong.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Grid_Danhsachphancong.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id_Doan"].Value);
            new QuanLyPhanCong_Sua(cellValue).ShowDialog();
            BindGrid();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int selectedrowindex = Grid_Danhsachphancong.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Grid_Danhsachphancong.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id_Doan"].Value);
            if (new PhanCongBUS().Delete(cellValue))
            {
                MessageBox.Show("Xóa thành công");
                BindGrid();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text;
            Grid_Danhsachphancong.DataSource = new PhanCongBUS().ListSearch(search);
        }
    }
}
