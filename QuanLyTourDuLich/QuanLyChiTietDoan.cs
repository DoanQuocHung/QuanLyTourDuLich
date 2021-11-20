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
    public partial class QuanLyChiTietDoan : Form
    {
        String id = "";
        public QuanLyChiTietDoan(string id)
        {
            InitializeComponent();
            this.id = id;
            BindGrid(id);
        }
        public void BindGrid(string id)
        {
            dataGridView1.DataSource = new ChiTietDoanBUS().List(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyChiTietDoan_Them ql_ctt_them = new QuanLyChiTietDoan_Them();
            ql_ctt_them.ShowDialog();
            BindGrid(id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_Doan"].Value);
                string cellValue2 = Convert.ToString(selectedRow.Cells["Id_Khach"].Value);
                QuanLyChiTietDoan_Sua ql_ctt_sua = new QuanLyChiTietDoan_Sua(cellValue, cellValue2);
                ql_ctt_sua.ShowDialog();
                BindGrid(id);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_Doan"].Value);
                string cellValue2 = Convert.ToString(selectedRow.Cells["Id_Khach"].Value);
                if (new ChiTietDoanBUS().Delete(cellValue, cellValue2))
                {
                    MessageBox.Show("Xóa thành công");
                    BindGrid(id);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BindGrid(id);
        }
    }
}
