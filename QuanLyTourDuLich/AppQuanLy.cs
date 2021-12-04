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
    public partial class AppQuanLy : Form
    {
        List<TourDTO> list;
        List<LoaiTourDTO> listloai;
        public AppQuanLy()
        {
            InitializeComponent();
            list = new TourBUS().List();
            listloai = new LoaiTourBUS().List();
            
        }

        //QUẢN LÝ TOUR ====================================================================================================================
        //Hàm lấy danh sách
        public void BindGrid(List<TourDTO> list, List<LoaiTourDTO> listloai)
        {
            foreach (TourDTO item in list)
            {
                table.Add();
            }
            Grid_Danhsachtour.RowsAdded = dt;
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
            string cellValue = Convert.ToString(selectedRow.Cells["Mã Tour"].Value);
            new QuanLyTour_Sua(cellValue).ShowDialog();
            BindGrid();
        }

        //Button Xóa 
        private void button3_Click(object sender, EventArgs e)
        {
            int selectedrowindex = Grid_Danhsachtour.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Grid_Danhsachtour.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Mã Tour"].Value);
            if (new TourBUS().Delete(cellValue))
            {
                MessageBox.Show("Xóa thành công");
                BindGrid();
            }
        }

        //Button Chi tiết 
        private void button4_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachtour.RowCount != 0)
            {
                int selectedrowindex = Grid_Danhsachtour.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachtour.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Mã Tour"].Value);
                if (cellValue != null)
                {
                    QuanLyChiTietTour ql_ctt = new QuanLyChiTietTour(cellValue);
                    ql_ctt.ShowDialog();
                }
            }
        }

        //Button Reload 
        private void button5_Click(object sender, EventArgs e)
        {
            BindGrid();
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

        private void button10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyDoan());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyChiPhi());
        }

        //Button chuyển trang Quản Lý Phân Công
        private void button12_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyPhanCong());
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
            string typesearch = SearchBox_cb.SelectedItem.ToString();
            string searchkey = SearchTour_txt.Text;
            DataTable searchtable = dt.Clone();
            searchtable.Clear();
            switch (typesearch)
            {
                case "Mã Tour":
                    foreach (DataRow item in dt.Rows)
                    {
                        if (item["Mã Tour"].ToString().Contains(searchkey))
                        {
                            searchtable.Rows.Add(
                                item["Mã Tour"],
                                item["Tên Tour"],
                                item["Mô Tả"],
                                item["Loại Tour"]);
                        }
                    }
                    break;
                case "Tên Tour":
                    foreach (DataRow item in dt.Rows)
                    {
                        if (item["Tên Tour"].ToString().Contains(searchkey))
                        {
                            searchtable.Rows.Add(
                                item["Mã Tour"],
                                item["Tên Tour"],
                                item["Mô Tả"],
                                item["Loại Tour"]);
                        }
                    }
                    break;
                case "Loại Tour":
                    foreach (DataRow item in dt.Rows)
                    {
                        if (item["Loại Tour"].ToString().Contains(searchkey))
                        {
                            searchtable.Rows.Add(
                                item["Mã Tour"],
                                item["Tên Tour"],
                                item["Mô Tả"],
                                item["Loại Tour"]);
                        }
                    }
                    break;
                default:
                    break;
            }
            Grid_Danhsachtour.DataSource = searchtable;
        }

        private void Grid_Danhsachtour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
