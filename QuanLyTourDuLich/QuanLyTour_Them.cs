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
    public partial class QuanLyTour_Them : Form
    {
        List<string> tenloai = new List<string>();
        public QuanLyTour_Them()
        {
            InitializeComponent();
            
            List<LoaiTourDTO> listloai = new LoaiTourBUS().List();
            foreach (LoaiTourDTO i in listloai)
            {
                tenloai.Add(i.Ten_Loai);
            }
            comboBox1.DataSource = tenloai;
            textBox1.Text = new TourBUS().MakeID();
        }
        /*
            try
            {
                
            }
            catch (DbEntityValidationException ex)
            {
                string errorMessages = string.Join("; ", ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.PropertyName + ": " + x.ErrorMessage));
                throw new DbEntityValidationException(errorMessages);
            }
         */
        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * if(comboBox1.SelectedItem.ToString().Equals("Đã đóng"))
                int trangthai = 1
             */
            string matour = textBox1.Text;
            string tentour = textBox2.Text;
            string dacdiem = textBox3.Text;
            string tenloai = comboBox1.SelectedItem.ToString();
            string idloai = new LoaiTourBUS().getID(tenloai);
            if (new TourBUS().Insert(new TourDTO(matour, tentour, dacdiem, idloai)))
            {
                MessageBox.Show("Thêm thành công");

                Hide();
            }
        }
    }
}
