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
    public partial class QuanLyGia : Form
    {
        List<GiaDTO> list;
        List<TourDTO> listtour;
        public QuanLyGia()
        {
            InitializeComponent();
            list = new GiaBUS().List();
            listtour = new TourBUS().List();
            GiaView.AutoGenerateColumns = false;
            List<string> listtype = new List<string> { "Mã Giá", "Mã Tour" };
            SearchBox_cb.DataSource = listtype;
            BindGrid(list);
        }
        public void BindGrid(List<GiaDTO> list)
        {
            GiaView.Rows.Clear();
            GiaView.Refresh();
            foreach (GiaDTO item in list)
            {
                GiaView.Rows.Add(item.Id_Gia,item.Id_Tour,item.Gia+"VNĐ",item.Thoigianbatdau,item.Thoigianketthuc);
                //string plit = item.Gia.Split('V')[0];
            }

            
        }
        private void SearchTour_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new QuanLyGia_Them(list, listtour))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.list = form.list;
                    BindGrid(list);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
