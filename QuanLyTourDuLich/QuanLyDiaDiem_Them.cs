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
    public partial class QuanLyDiaDiem_Them : Form
    {
        public QuanLyDiaDiem_Them()
        {
            InitializeComponent();
            textBox1.Text = new DiaDiemBUS().MakeID();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string madiadiem = textBox1.Text;
            string tendiadiem = textBox2.Text;
            if (new DiaDiemBUS().Insert(new DiaDiemDTO(madiadiem, tendiadiem)))
            {
                MessageBox.Show("Thêm thành công");
                Hide();
            }
        }
    }
}
