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
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
            BindGrid();
        }

        public void BindGrid()
        {
            Grid_Danhsachnhanvien.DataSource = new NhanVienBUS().List();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new QuanLyNhanVien_Them().ShowDialog();
            BindGrid();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int selectedrowindex = Grid_Danhsachnhanvien.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Grid_Danhsachnhanvien.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id_NV"].Value);
            new QuanLyNhanVien_Sua(cellValue).ShowDialog();
            BindGrid();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int selectedrowindex = Grid_Danhsachnhanvien.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Grid_Danhsachnhanvien.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id_NV"].Value);
            if (new NhanVienBUS().Delete(cellValue))
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
            Grid_Danhsachnhanvien.DataSource = new NhanVienBUS().ListSearch(search);
        }
    }
}
