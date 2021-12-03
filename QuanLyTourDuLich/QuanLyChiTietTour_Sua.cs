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
        List<DiaDiemDTO> listdd = new List<DiaDiemDTO>();
        public QuanLyChiTietTour_Sua(string id,string diadiem)
        {
            InitializeComponent();
            ChiTietTourDTO edit = new ChiTietTourDTO();
            edit = new ChiTietTourBUS().get(id,diadiem);

            /*IdTour_txt.Text = edit.Id_Tour;
            textBox2.Text = edit.Id_DiaDiem;
            textBox3.Text = edit.Thutu.ToString();*/
            listdd = new DiaDiemBUS().List();
            List<string> listname = new List<string>();
            foreach (DiaDiemDTO item in listdd)
            {
                listname.Add(item.Ten_DiaDiem);
            }
            DiaDiem_cb.DataSource = listname;
            IdTour_txt.Text = ID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string matour = IdTour_txt.Text;
            string madiadiem = textBox2.Text;
            int thutu = Int32.Parse(textBox3.Text);

            if (new ChiTietTourBUS().Update(new ChiTietTourDTO(matour, madiadiem, thutu)))
            {
               MessageBox.Show("Sửa thành công");
                Hide();
            }*/
        }
    }
}
