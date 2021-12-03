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
    public partial class QuanLyChiTietTour : Form
    {
        String id = "";
        public QuanLyChiTietTour(String id)
        {
            InitializeComponent();
            this.id = id;
            BindGrid(id);
        }
        //QUẢN LÝ CHI TIẾT TOUR ===========================================================================================================
        //Hàm lấy danh sách
        public void BindGrid(string id)
        {
            List<TourDTO> list = new TourBUS().List();
            dt = new DataTable();

            //Tạo cấu trúc bảng
            dt.Columns.AddRange(new DataColumn[4] {
                new DataColumn("Mã Tour"),
                new DataColumn("Tên Tour"),
                new DataColumn("Mô tả"),
                new DataColumn("Loại Tour") });
            //Gán giá trị cho combobox tìm kiếm
            string[] searchitems = { "Mã Tour", "Tên Tour", "Loại Tour" };
            SearchBox_cb.DataSource = searchitems;
            //Đưa giá trị vào datatable
            foreach (TourDTO item in list)
            {
                string tenloai = new LoaiTourBUS().getName(item.Id_Loai);
                dt.Rows.Add(item.Id_Tour, item.Ten_Tour, item.Dacdiem_Tour, tenloai);
            }
            //Đưa giá trị vào bảng
            Grid_Danhsachtour.DataSource = dt;
            dataGridView1.DataSource = new ChiTietTourBUS().List(id);
        }

        //Button Thêm
        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyChiTietTour_Them ql_ctt_them = new QuanLyChiTietTour_Them();
            ql_ctt_them.ShowDialog();
            BindGrid(id);
        }

        //Button Sửa
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_Tour"].Value);
                string cellValue2 = Convert.ToString(selectedRow.Cells["Id_DiaDiem"].Value);
                QuanLyChiTietTour_Sua ql_ctt_sua = new QuanLyChiTietTour_Sua(cellValue, cellValue2);
                ql_ctt_sua.ShowDialog();
                BindGrid(id);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            BindGrid(id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_Tour"].Value);
                string cellValue2 = Convert.ToString(selectedRow.Cells["Id_DiaDiem"].Value);
                if (new ChiTietTourBUS().Delete(cellValue, cellValue2))
                {
                    MessageBox.Show("Xóa thành công");
                    BindGrid(id);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }
    }
}
