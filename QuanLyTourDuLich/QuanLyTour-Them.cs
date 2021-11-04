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
    public partial class QuanLyTour_Them : Form
    {
        LoaiTourBUS BUS;
        TourBUS tourBus;
        public QuanLyTour_Them()
        {
            InitializeComponent();
            BUS = new LoaiTourBUS();
            tourBus = new TourBUS();
            BUS.List(comboBox1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matour = textBox1.Text;
            string tentour = textBox2.Text;
            string dacdiem = textBox3.Text;
            string tenloai = comboBox1.SelectedIndex.ToString();
            string loai = BUS.get(tenloai).Id_Loai;
            tourBus.Insert(matour,tentour,dacdiem,loai);
        }
    }
}
