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
        public bool Update(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string matour = row.Cells["MATOUR"].Value.ToString();
            string tentour = row.Cells["TENTOUR"].Value.ToString();
            string dacdiem = row.Cells["DACDIEM"].Value.ToString();
            string maloai = row.Cells["MALOAI"].Value.ToString();

            TourDTO tour = new TourDTO(matour, tentour, dacdiem, maloai);

            return dao.Update(matour, tour);
        }

        public bool Insert(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string matour = row.Cells["MATOUR"].Value.ToString();
            string tentour = row.Cells["TENTOUR"].Value.ToString();
            string dacdiem = row.Cells["DACDIEM"].Value.ToString();
            string maloai = row.Cells["MALOAI"].Value.ToString();

            TourDTO tour = new TourDTO(matour, tentour, dacdiem, maloai);

            return dao.Update(matour, tour);
        }
        public bool Delete(string data)
        {
            return dao.Delete(data);
        }
    }
}
