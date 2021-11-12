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
    public partial class QuanLyChiTietTour_Sua : Form
    {
        public QuanLyChiTietTour_Sua(string id)
        {
            InitializeComponent();
            new ChiTietTourBUS().get(id, textBox1, textBox2, textBox3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matour = textBox1.Text;
            string madiadiem = textBox2.Text;
            int thutu = Int32.Parse(textBox3.Text);

            if (new ChiTietTourBUS().Update(matour, madiadiem, thutu))
            {
                MessageBox.Show("Sửa thành công");
                Hide();
            }
        }
    }
}
