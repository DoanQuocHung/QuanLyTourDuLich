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
    public partial class QuanLyTour_Sua : Form
    {
        List<string> tenloai = new List<string>();
        public QuanLyTour_Sua(string id)
        {
            InitializeComponent();
            List<LoaiTourDTO> listloai = new LoaiTourBUS().List();
            foreach (LoaiTourDTO i in listloai)
            {
                tenloai.Add(i.Ten_Loai);
            }
            comboBox2.DataSource = tenloai;
            TourDTO edit = new TourDTO();
            edit = new TourBUS().ListSearch(id)[0];

            textBox1.Text = edit.Id_Tour;
            textBox2.Text = edit.Ten_Tour;
            textBox3.Text = edit.Dacdiem_Tour;
            comboBox2.SelectedItem = new LoaiTourBUS().getName(edit.Id_Loai);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matour = textBox1.Text;
            string tentour = textBox2.Text;
            string dacdiem = textBox3.Text;
            string tenloai = comboBox2.SelectedItem.ToString();
            if (new TourBUS().Update(new TourDTO(matour, tentour, dacdiem, new LoaiTourBUS().getID(tenloai))))
            {
                MessageBox.Show("Sửa thành công");
                Hide();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
