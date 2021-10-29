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
        public static TourBUS instance;

        public TourBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TourBUS();
                return instance;
            }
        }

        public TourBUS() { }

        public void List(DataGridView data)
        {
            data.DataSource = TourDAO.instance.List();
        }
        public bool Update(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string matour = row.Cells["MATOUR"].Value.ToString();
            string tentour = row.Cells["TENTOUR"].Value.ToString();
            string dacdiem = row.Cells["DACDIEM"].Value.ToString();
            string maloai = row.Cells["MALOAI"].Value.ToString();

            TourDTO tour = new TourDTO(matour, tentour, dacdiem, maloai);

            return TourDAO.instance.Update(matour, tour);
        }

        public bool Insert(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string matour = row.Cells["MATOUR"].Value.ToString();
            string tentour = row.Cells["TENTOUR"].Value.ToString();
            string dacdiem = row.Cells["DACDIEM"].Value.ToString();
            string maloai = row.Cells["MALOAI"].Value.ToString();

            TourDTO tour = new TourDTO(matour, tentour, dacdiem, maloai);

            return TourDAO.instance.Update(matour, tour);
        }
        public bool Delete(string data)
        {
            return TourDAO.instance.Delete(data);
        }
    }
}
