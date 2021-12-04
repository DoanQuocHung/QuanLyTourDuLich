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
    public partial class QuanLyChiTietTour_Them : Form
    {
        List<DiaDiemDTO> listdd = new List<DiaDiemDTO>();
        public List<ChiTietTourDTO> list { get; set; }
        public QuanLyChiTietTour_Them(List<ChiTietTourDTO> list, List<DiaDiemDTO> listdd,string id)
        {
            InitializeComponent();
            this.list = list;
            this.listdd = listdd;
            List<string> listname = new List<string>();
            foreach (DiaDiemDTO item in listdd)
            {
                DiaDiem_cb.Items.Add(item.Ten_DiaDiem);
            }
            IdTour_txt.Text = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matour = IdTour_txt.Text;
            string diadiem = DiaDiem_cb.Text;
            string iddiadiem = listdd.Find(x=>x.Ten_DiaDiem.Equals(diadiem)).Id_DiaDiem;
            int thutu = Int32.Parse(ThuTu_num.Text);
            if(diadiem.Equals(null))
            {
                MessageBox.Show("Vui lòng chọn địa điểm");
                return;
            }
            if (thutu==null || thutu <= 0)
            {
                MessageBox.Show("Vui lòng nhập thứ tự lớn 0");
                return;
            }
            if (new ChiTietTourBUS().Insert(new ChiTietTourDTO(matour, iddiadiem, thutu)))
            {
                MessageBox.Show("Thêm thành công");
                this.list.Add(new ChiTietTourDTO(matour, iddiadiem, thutu));
                this.DialogResult = DialogResult.OK;
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
