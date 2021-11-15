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
            dataGridView1.DataSource = new ChiTietTourBUS().List(id);
        }

        //Button Thêm
        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyChiTietTour_Them ql_ctt_them = new QuanLyChiTietTour_Them();
            ql_ctt_them.ShowDialog();
        }

        //Button Sửa
        private void button2_Click(object sender, EventArgs e)
        {
            int selectedrowindex =  dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id_Tour"].Value);
            QuanLyChiTietTour_Sua ql_ctt_sua = new QuanLyChiTietTour_Sua(cellValue);
            ql_ctt_sua.ShowDialog();
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
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id_Tour"].Value);
            string cellValue2 = Convert.ToString(selectedRow.Cells["Id_DiaDiem"].Value);
            if (new ChiTietTourBUS().Delete(cellValue,cellValue2))
            {
                MessageBox.Show("Xóa thành công");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }
    }
}
