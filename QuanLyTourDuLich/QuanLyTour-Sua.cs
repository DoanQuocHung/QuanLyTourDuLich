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
    public partial class QuanLyTour_Sua : Form
    {
        LoaiTourBUS BUS;
        TourBUS tourBus;
        public QuanLyTour_Sua(string matour,string tentour,string dacdiem,string maloai)
        {
            InitializeComponent();
            string loai = maloai;
            BUS = new LoaiTourBUS();
            tourBus = new TourBUS();
            BUS.List(comboBox1);
            textBox1.Text = matour;
            textBox2.Text = tentour;
            textBox3.Text = dacdiem;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
