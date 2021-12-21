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
    public partial class QuanLyGia_Them : Form
    {
        public List<GiaDTO> list { get; set; }
        public QuanLyGia_Them(List<GiaDTO> list, List<TourDTO> listtour)
        {
            InitializeComponent();
            txtGia.Text = new GiaBUS().MakeID();
            foreach (TourDTO item in listtour)
            {
                TourView.Rows.Add(item.Id_Tour,item.Ten_Tour,item.Dacdiem_Tour);
            }
        }

        private void TourView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = TourView.SelectedRows[0].Index;
            DataGridViewRow selectedRow = TourView.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id_Tour"].Value);
            txtTour.Text = cellValue;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string magia = txtGia.Text;
            string matour = txtTour.Text;
            string gia = numGia.Text;
            string ngaybatdau = txtNgayKhoiHanh.Text;
            string ngayketthuc = txtNgayKetThuc.Text;
            if (matour.Equals(null) || matour.Equals(""))
            {
                MessageBox.Show("Vui lòng Chọn tour trong bảng");
                return;
            }
            string idloai = new LoaiTourBUS().getID(tenloai);
            if (new TourBUS().Insert(new TourDTO(matour, tentour, dacdiem, idloai)))
            {
                MessageBox.Show("Thêm thành công");
                this.list.Add(new TourDTO(matour, tentour, dacdiem, idloai));
                this.DialogResult = DialogResult.OK;
                Hide();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}
