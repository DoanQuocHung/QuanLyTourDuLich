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
    public partial class QuanLyChiTietTour_Sua : Form
    {
        List<DiaDiemDTO> listdd = new List<DiaDiemDTO>();
        public QuanLyChiTietTour_Sua(string id,string diadiem,string thutu)
        {
            InitializeComponent();
            listdd = new DiaDiemBUS().List();
            List<string> listname = new List<string>();
            foreach (DiaDiemDTO item in listdd)
            {
                listname.Add(item.Ten_DiaDiem);
            }
            DiaDiem_cb.DataSource = listname;
            IdTour_txt.Text = id;
            DiaDiem_cb.SelectedItem = diadiem;
            ThuTu_num.Value = Int32.Parse(thutu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matour = IdTour_txt.Text;
            string diadiem = DiaDiem_cb.Text;
            int thutu = Int32.Parse(ThuTu_num.Text);
            if (diadiem.Equals(null))
            {
                MessageBox.Show("Vui lòng nhập hoặc chọn địa điểm");
                return;
            }
            if (thutu == null || thutu <= 0)
            {
                MessageBox.Show("Vui lòng nhập thứ tự lớn 0");
                return;
            }
            string madiadiem = "";
            int count = 0;
            foreach (DiaDiemDTO item in listdd)
            {
                if (item.Ten_DiaDiem.Equals(diadiem))
                {
                    madiadiem = item.Id_DiaDiem;
                    count = 1;
                }
            }
            if (count == 1)
            {
                if (new ChiTietTourBUS().Update(new ChiTietTourDTO(matour, madiadiem, thutu)))
                {
                    MessageBox.Show("Sửa thành công");
                    Hide();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Tạo địa điểm mới ?", "Tạo địa điểm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    madiadiem = new DiaDiemBUS().MakeID();
                    if (new DiaDiemBUS().Insert(new DiaDiemDTO(madiadiem, diadiem)))
                    {
                        if (new ChiTietTourBUS().Update(new ChiTietTourDTO(matour, madiadiem, thutu)))
                        {
                            MessageBox.Show("Tạo địa điểm và sửa chi tiết thành công");
                            Hide();
                        }
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }
    }
}
