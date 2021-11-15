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
        public QuanLyChiTietTour_Sua(string id,string diadiem)
        {
            InitializeComponent();
            ChiTietTourDTO edit = new ChiTietTourDTO();
            edit = new ChiTietTourBUS().get(id,diadiem);

            textBox1.Text = edit.Id_Tour;
            textBox2.Text = edit.Id_DiaDiem;
            textBox3.Text = edit.Thutu.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matour = textBox1.Text;
            string madiadiem = textBox2.Text;
            int thutu = Int32.Parse(textBox3.Text);

            if (new ChiTietTourBUS().Update(new ChiTietTourDTO(matour, madiadiem, thutu)))
            {
               MessageBox.Show("Sửa thành công");
                Hide();
            }
        }
    }
}
