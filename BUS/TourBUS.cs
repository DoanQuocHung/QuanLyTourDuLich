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

        public List<TourDTO> List(DataGridView data)
        {
            return new TourDAO().ListAll();
        }
        public List<TourDTO> ListSearch(DataGridView data,TextBox text)
        {
           return new TourDAO().List(text.Text.ToString());
        }
        public void getName(string id)
        {
            new LoaiTourDAO().getName(id);
        }
        public bool Update(string matour, TourDTO tour)
        {
            return new TourDAO().Update(matour,tour);
            //
        }

        public bool Insert(TourDTO tour)
        {
            return new TourDAO().Insert(tour);
            //Hung
        }
        public bool Delete(string matour)
        {
            return new TourDAO().Delete(matour);
        }
    }
}
