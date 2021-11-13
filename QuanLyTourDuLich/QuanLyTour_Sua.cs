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
        public QuanLyTour_Sua(string id)
        {
            InitializeComponent();
            //new TourBUS().get(id,textBox1,textBox2,textBox3,comboBox2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string matour = textBox1.Text;
            //string tentour = textBox2.Text;
            //string dacdiem = textBox3.Text;
            //string tenloai = comboBox2.SelectedItem.ToString();

            //if (new TourBUS().Update(matour, tentour, dacdiem, tenloai))
            //{
            //    MessageBox.Show("Sửa thành công");
            //    Hide();
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
