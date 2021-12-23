using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Globalization;
using System.Threading;

namespace QuanLyTourDuLich
{
    public partial class QuanLyDoan_Sua : Form
    {
        public List<DoanDuLichDTO> list { get; set; }
        List<TourDTO> listTenTour;
        public QuanLyDoan_Sua(List<DoanDuLichDTO> list, List<TourDTO> listTenTour, string id)
        {
            InitializeComponent();
            this.list = list;
            this.listTenTour = listTenTour;

            foreach (TourDTO i in this.listTenTour)
            {
                cbTenTour.Items.Add(i.Ten_Tour);
            }
            DoanDuLichDTO item = list.Find(x => x.Id_Doan.Equals(id));
            txtMaDoan.Text = id;
            txtTenDoan.Text = item.Ten_Doan;
            txtNgayKhoiHanh.Value = DateTime.ParseExact(item.Ngaykhoihanh, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            txtNgayKetThuc.Value = DateTime.ParseExact(item.Ngayketthuc, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            txtDoanhThu.Text = item.Doanhthu.ToString();
            cbTenTour.SelectedItem = listTenTour.Find(x => x.Id_Tour.Equals(item.Id_Tour)).Ten_Tour;
            txtNoiDung.Text = item.Noidung;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string madoan = txtMaDoan.Text;
            string tendoan = txtTenDoan.Text;
            string tentour = cbTenTour.SelectedItem.ToString();
            string idtour = listTenTour.Find(x => x.Ten_Tour.Equals(tentour)).Id_Tour;
            string ngaykhoihanh = txtNgayKhoiHanh.Text;
            string ngayketthuc = txtNgayKetThuc.Text;
            string noidung = txtNoiDung.Text;
            long doanhthu = (long)Convert.ToDouble(txtDoanhThu.Text);
            if (tendoan.Equals("") || tentour.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ");
                return;
            }
            if (txtNgayKhoiHanh.Value.ToString("dd/MM/yyyy").Equals("") || txtNgayKetThuc.Value.ToString("dd/MM/yyyy").Equals(""))
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ");
                return;
            }
            DateTime dtNgKhoiHanh = DateTime.ParseExact(ngaykhoihanh, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTime dtNgKetThuc = DateTime.ParseExact(ngayketthuc, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTime today = DateTime.Today;
            int resultCompareTodayAndNgayKhoiHanh = DateTime.Compare(dtNgKhoiHanh, today);
            int resultCompareTodayAndNgayKetThuc = DateTime.Compare(dtNgKetThuc, today);
            int resultCompareNgayKhoiHanhAndNgayKetThuc = DateTime.Compare(dtNgKhoiHanh, dtNgKetThuc);
            if ((resultCompareTodayAndNgayKhoiHanh < 0) || (resultCompareTodayAndNgayKetThuc < 0) || (resultCompareNgayKhoiHanhAndNgayKetThuc > 0))
            {
                MessageBox.Show("Vui lòng nhập lại thông tin ngày khởi hành hoặc ngày kết thúc");
                return;
            }
            if (new DoanDuLichBUS().Update(new DoanDuLichDTO(madoan, tendoan, idtour, ngaykhoihanh, ngayketthuc, doanhthu, noidung)))
            {
                MessageBox.Show("Sửa thành công");
                list.Find(x => x.Id_Doan.Equals(madoan)).Ten_Doan = tendoan;
                list.Find(x => x.Id_Doan.Equals(madoan)).Id_Tour = idtour;
                list.Find(x => x.Id_Doan.Equals(madoan)).Ngaykhoihanh = ngaykhoihanh;
                list.Find(x => x.Id_Doan.Equals(madoan)).Ngayketthuc = ngayketthuc;
                list.Find(x => x.Id_Doan.Equals(madoan)).Doanhthu = doanhthu;
                list.Find(x => x.Id_Doan.Equals(madoan)).Noidung = noidung;
                this.DialogResult = DialogResult.OK;
                Hide();
            }
        }

        private void QuanLyDoan_Them_Load(object sender, EventArgs e)
        {
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
