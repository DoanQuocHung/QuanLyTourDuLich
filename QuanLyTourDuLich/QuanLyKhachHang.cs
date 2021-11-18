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
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
            BindGrid();
        }
        public void BindGrid()
        {
            Grid_Danhsachkhachhang.DataSource = new KhachHangBUS().List();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new QuanLyKhachHang_Them().ShowDialog();
            BindGrid();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int selectedrowindex = Grid_Danhsachkhachhang.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Grid_Danhsachkhachhang.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id_Khach"].Value);
            new QuanLyKhachHang_Sua(cellValue).ShowDialog();
            BindGrid();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int selectedrowindex = Grid_Danhsachkhachhang.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Grid_Danhsachkhachhang.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id_Khach"].Value);
            if (new KhachHangBUS().Delete(cellValue))
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
            Grid_Danhsachkhachhang.DataSource = new KhachHangBUS().ListSearch(search);
        }
    }
}
