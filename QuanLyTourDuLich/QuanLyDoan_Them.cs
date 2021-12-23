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
    public partial class QuanLyDoan_Them : Form
    {
        public List<DoanDuLichDTO> list { get; set; }
        List<TourDTO> listTenTour;
        public QuanLyDoan_Them(List<DoanDuLichDTO> list, List<TourDTO> listTenTour)
        {
            InitializeComponent();
            this.list = list;
            this.listTenTour = listTenTour;

            foreach (TourDTO i in this.listTenTour)
            {
                cbTenTour.Items.Add(i.Ten_Tour);
            }
            cbTenTour.SelectedItem = listTenTour[0].Ten_Tour;
            txtMaDoan.Text = new DoanDuLichBUS().MakeID();
            txtTenDoan.Text = listTenTour[0].Ten_Tour;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string madoan = txtMaDoan.Text;
            string tendoan = txtTenDoan.Text;
            string tentour = cbTenTour.SelectedItem.ToString();
            string idtour = listTenTour.Find(x => x.Ten_Tour.Equals(tentour)).Id_Tour;
            string ngaykhoihanh = txtNgayKhoiHanh.Text;
            string ngayketthuc = txtNgayKetThuc.Text;
            long doanhthu = 0;
            string noidung = txtNoiDung.Text;
            if (txtTenDoan.Text.Equals("") || tentour.Equals("") || txtNgayKhoiHanh.Text.Equals("") || txtNgayKetThuc.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ");
                return;
            }
            
            DateTime today = DateTime.Today;
            DateTime dtNgKhoiHanh = DateTime.ParseExact(ngaykhoihanh, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTime dtNgKetThuc = DateTime.ParseExact(ngayketthuc, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            int resultCompareNgayKhoiHanh = DateTime.Compare(dtNgKhoiHanh, today);
            int resultCompareNgayKetThuc = DateTime.Compare(dtNgKetThuc, today);
            int resultCompareNgayKhoiHanhAndNgayKetThuc = DateTime.Compare(dtNgKhoiHanh, dtNgKetThuc);
            if ((resultCompareNgayKhoiHanh < 0) || (resultCompareNgayKetThuc < 0) || (resultCompareNgayKhoiHanhAndNgayKetThuc > 0))
            {
                MessageBox.Show("Vui lòng nhập lại thông tin ngày khởi hành hoặc ngày kết thúc");
                return;
            }
            if (new DoanDuLichBUS().Insert(new DoanDuLichDTO(madoan, tendoan, idtour, ngaykhoihanh, ngayketthuc, doanhthu, noidung)))
            {
                MessageBox.Show("Thêm thành công");
                this.list.Add(new DoanDuLichDTO(madoan, tendoan, idtour, ngaykhoihanh, ngayketthuc, doanhthu, noidung));
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

        private void cbTenTour_DropDownClosed(object sender, EventArgs e)
        {
            if (cbTenTour.ValueMember != null)
            {
                string strTenTour = cbTenTour.SelectedItem.ToString();
                txtTenDoan.Text = strTenTour;
            }
        }
    }
}
