using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QuanLyTourDuLich
{
    public partial class QuanLyChiPhi : Form
    {
        public QuanLyChiPhi()
        {
            InitializeComponent();
        }
       /* public void BindGrid()
        {
            Grid_Danhsachtour.DataSource = new ChiPhiBUS().List();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyChiPhi_Them ql_ctt_them = new QuanLyChiPhi_Them();
            ql_ctt_them.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachtour.RowCount != 0)
            {
                int selectedrowindex = Grid_Danhsachtour.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachtour.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_LoaiChiPhi"].Value);
                string cellValue2 = Convert.ToString(selectedRow.Cells["Id_Doan"].Value);
                QuanLyChiPhi_Sua ql_ctt_sua = new QuanLyChiPhi_Sua(cellValue, cellValue2);
                ql_ctt_sua.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachtour.RowCount != 0)
            {
                int selectedrowindex = Grid_Danhsachtour.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachtour.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_LoaiChiPhi"].Value);
                string cellValue2 = Convert.ToString(selectedRow.Cells["Id_Doan"].Value);
                if (new ChiPhiBUS().Delete(cellValue, cellValue2))
                {
                    MessageBox.Show("Xóa thành công");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }*/
    }
}
