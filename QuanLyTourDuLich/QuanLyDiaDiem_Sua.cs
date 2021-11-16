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
    public partial class QuanLyDiaDiem_Sua : Form
    {
        public QuanLyDiaDiem_Sua(string id)
        {
            InitializeComponent();
            DiaDiemDTO edit = new DiaDiemDTO();
            edit = new DiaDiemBUS().ListSearch(id)[0];

            textBox1.Text = edit.Id_DiaDiem;
            textBox2.Text = edit.Ten_DiaDiem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string madiadiem = textBox1.Text;
            string tendiadiem = textBox2.Text;
            if (new DiaDiemBUS().Update(new DiaDiemDTO(madiadiem, tendiadiem)))
            {
                MessageBox.Show("Sửa thành công");
                Hide();
            }
        }
    }
}
