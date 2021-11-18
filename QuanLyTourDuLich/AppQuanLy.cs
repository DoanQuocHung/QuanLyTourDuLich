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
    public partial class AppQuanLy : Form
    {

        public AppQuanLy()
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
        }

        //Button Sửa 
        private void button2_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachtour.RowCount != 0)
            {
                int selectedrowindex = Grid_Danhsachtour.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachtour.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_Tour"].Value);
                new QuanLyTour_Sua(cellValue).ShowDialog();
            }
        }

        //Button Xóa 
        private void button3_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachtour.RowCount != 0)
            {
                int selectedrowindex = Grid_Danhsachtour.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachtour.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_Tour"].Value);
                if (new TourBUS().Delete(cellValue))
                {
                    MessageBox.Show("Xóa thành công");
                }
            }
        }

        //Button Chi tiết 
        private void button4_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachtour.RowCount != 0)
            {
                int selectedrowindex = Grid_Danhsachtour.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachtour.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_Tour"].Value);
                QuanLyChiTietTour ql_ctt = new QuanLyChiTietTour(cellValue);
                ql_ctt.ShowDialog();
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
            Grid_Danhsachtour.DataSource = new TourBUS().ListSearch(search);
        }


        //LEFT MENU BAR ===================================================================================================================
        //Button chuyển trang Quản Lý Tour  
        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyTour());
        }

        //Button chuyển trang Quản Lý Nhân viên
        private void button14_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyNhanVien());
        }

        //Button chuyển trang Quản Lý Khách hàng
        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyKhachHang());
        }



        //Button chuyển trang Quản Lý Địa điểm
        private void button13_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyDiaDiem());
        }


        //Hàm xử lý chuyển trang ==========================================================================================================
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        //Other ===========================================================================================================================
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Grid_Danhsachtour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyChiPhi());
        }
    }
}
