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
        public QuanLyTour_Them()
        {
            InitializeComponent();
            //new LoaiTourBUS().List(comboBox1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //string matour = textBox1.Text;
            //string tentour = textBox2.Text;
            //string dacdiem = textBox3.Text;
            //string tenloai = comboBox1.SelectedItem.ToString();

            //if (new TourBUS().Insert(matour, tentour, dacdiem, tenloai))
            //{
            //    MessageBox.Show("Thêm thành công");
            //    Hide();
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
