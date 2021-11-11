using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
namespace BUS
{
    public class TourBUS
    {
        public TourBUS() { }

        private TourDAO dao = new TourDAO();
        public void List(DataGridView data)
        {
            data.DataSource = dao.List();
        }
        public void get(string id,TextBox num1,TextBox num2, TextBox num3,ComboBox cb)
        {
            List<string> get = new List<string>();
            TourDTO tour = new TourDAO().get(id);
            num1.Text = tour.Id_Tour;
            num2.Text = tour.Ten_Tour;
            num3.Text = tour.Dacdiem_Tour;
            cb.DataSource = new LoaiTourDAO().List();
            cb.SelectedItem = new LoaiTourDAO().getname(tour.Id_Loai);
        }
        public bool Update(string matour, string tentour, string dacdiem, string tenloai)
        {
            string ma = matour;
            string ten = tentour;
            string dd = dacdiem;
            LoaiTourDAO loaidao = new LoaiTourDAO();
            string maloai = loaidao.get(tenloai);
            TourDTO tour = new TourDTO(matour, tentour, dacdiem, maloai);
            return dao.Update(matour,tour);
        }

        public bool Insert(string matour,string tentour,string dacdiem,string tenloai)
        {
            string ma = matour;
            string ten = tentour;
            string dd = dacdiem;
            LoaiTourDAO loaidao = new LoaiTourDAO();
            string maloai=loaidao.get(tenloai);
            TourDTO tour = new TourDTO(matour, tentour, dacdiem, maloai);
            return dao.Insert(tour);
            //Hung
        }
        public bool Delete(string data)
        {
            return dao.Delete(data);
        }
    }
}
