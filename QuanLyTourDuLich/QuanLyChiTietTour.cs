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
        string id = "";
        List<ChiTietTourDTO> list;
            List<DiaDiemDTO> listdd = new List<DiaDiemDTO>();
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
            list = new ChiTietTourBUS().List(id);
            listdd = new DiaDiemBUS().List();
            DataTable dt2 = new DataTable();

            //Add columns to DataTable.
            dt2.Columns.AddRange(new DataColumn[3] { new DataColumn("Mã địa điểm"), new DataColumn("Tên địa điểm"), new DataColumn("Thứ tự đi") });

            foreach (ChiTietTourDTO item in list)
            {
                string tendiadiem = "";
                foreach (DiaDiemDTO dd in listdd)
                {
                    if(item.Id_DiaDiem.Equals(dd.Id_DiaDiem))
                        tendiadiem = dd.Ten_DiaDiem;
                }
                dt2.Rows.Add(item.Id_DiaDiem, tendiadiem, item.Thutu);
            }
            Grid_chitiettour.DataSource = dt2;
        }

        //Button Thêm
        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyChiTietTour_Them ql_ctt_them = new QuanLyChiTietTour_Them(id);
            ql_ctt_them.ShowDialog();
            BindGrid(id);
        }

        //Button Sửa
        private void button2_Click(object sender, EventArgs e)
        {
            if (Grid_chitiettour.RowCount != 0)
            {
                int selectedrowindex = Grid_chitiettour.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_chitiettour.Rows[selectedrowindex];
                string cellValue = id;
                string cellValue2 = Convert.ToString(selectedRow.Cells["Mã địa điểm"].Value);
                string cellValue3 = Convert.ToString(selectedRow.Cells["Thứ tự đi"].Value);
                QuanLyChiTietTour_Sua ql_ctt_sua = new QuanLyChiTietTour_Sua(cellValue, cellValue2, cellValue3);
                ql_ctt_sua.ShowDialog();
                BindGrid(id);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BindGrid(id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Grid_chitiettour.RowCount != 0)
            {
                int selectedrowindex = Grid_chitiettour.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_chitiettour.Rows[selectedrowindex];
                string cellValue = id;
                string cellValue2 = Convert.ToString(selectedRow.Cells["Mã địa điểm"].Value);
                if(new ChiTietTourBUS().Delete(cellValue,cellValue2))
                {
                    MessageBox.Show("Xóa chi tiết thành công");
                    BindGrid(id);
                }
            }
        }
    }
}
